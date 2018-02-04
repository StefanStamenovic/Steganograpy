#include <stdio.h>
#include <string>
#include "cuda_runtime.h"

#define _val(ptr) *ptr
//----------------------------------------------------------------------------------------
// EXCEPTION HANDLING
//----------------------------------------------------------------------------------------

class Exception {
public:
	static char* message;
public:
	Exception() {
		if (this->message != NULL)
			delete this->message;
		this->message = NULL;
		message = new char[1];
		strcpy(this->message, "");
	}
	Exception(const char* message) {
		if (this->message != NULL)
			delete this->message;
		this->message = NULL;
		this->message = new char[strlen(message) + 1];
		strcpy(this->message, message);
	}
};
char* Exception::message = NULL;

///////////////////////////////////////////////////////////////////
// Returns last exception message.
///////////////////////////////////////////////////////////////////
extern "C" void _declspec(dllexport) _stdcall GetLastException(char* _exception)
{
	strcpy(_exception, Exception::message);
	Exception no_exception("There is no CUDA exception.");
}

//----------------------------------------------------------------------------------------
// DEVICE INFO
//----------------------------------------------------------------------------------------

///////////////////////////////////////////////////////////////////
// Checks for is CUDA available.
///////////////////////////////////////////////////////////////////
extern "C" bool _declspec(dllexport) _stdcall CUDA_Check() {
	int deviceCount = 0;
	cudaError_t cuda_error = cudaGetDeviceCount(&deviceCount);
	if (cuda_error != cudaSuccess || deviceCount < 1)
		return false;
	return true;
}

///////////////////////////////////////////////////////////////////
// Compute num of cores from version.
///////////////////////////////////////////////////////////////////
inline int _ConvertSMVer2Cores(
	int major,
	int minor)
{
	// Defines for GPU Architecture types (using the SM version to determine the # of cores per SM
	typedef struct
	{
		int SM; // 0xMm (hexidecimal notation), M = SM Major version, and m = SM minor version
		int Cores;
	} sSMtoCores;

	sSMtoCores nGpuArchCoresPerSM[] =
	{
		{ 0x30, 192 }, // Kepler Generation (SM 3.0) GK10x class
		{ 0x32, 192 }, // Kepler Generation (SM 3.2) GK10x class
		{ 0x35, 192 }, // Kepler Generation (SM 3.5) GK11x class
		{ 0x37, 192 }, // Kepler Generation (SM 3.7) GK21x class
		{ 0x50, 128 }, // Maxwell Generation (SM 5.0) GM10x class
		{ 0x52, 128 }, // Maxwell Generation (SM 5.2) GM20x class
		{ 0x53, 128 }, // Maxwell Generation (SM 5.3) GM20x class
		{ 0x60, 64 }, // Pascal Generation (SM 6.0) GP100 class
		{ 0x61, 128 }, // Pascal Generation (SM 6.1) GP10x class
		{ 0x62, 128 }, // Pascal Generation (SM 6.2) GP10x class
		{ 0x70, 64 }, // Volta Generation (SM 7.0) GV100 class

		{ -1, -1 }
	};

	int index = 0;

	while (nGpuArchCoresPerSM[index].SM != -1)
	{
		if (nGpuArchCoresPerSM[index].SM == ((major << 4) + minor))
		{
			return nGpuArchCoresPerSM[index].Cores;
		}

		index++;
	}

	// Can't compute cores number 
	return -1;
}

///////////////////////////////////////////////////////////////////
// Getting info about best cuda device.
///////////////////////////////////////////////////////////////////
extern "C" void _declspec(dllexport) _stdcall CUDA_BestDeviceInfo(
	int* device,
	char* name,
	float* driver_version,
	float* runtime_version,
	float* capability_version,
	int* global_memory,
	int* memory_clock_rate,
	int* multyprocessors_num,
	int* memory_bus_width,
	int* cuda_cores_num,
	int* clock_rate
)throw(char*) {
	// Getting device count
	int deviceCount = 0;
	cudaError_t cuda_error = cudaGetDeviceCount(&deviceCount);
	if (cuda_error != cudaSuccess  || deviceCount < 1)
		throw Exception("There is no cuda enabled devices.");
	
	// Finding best CUDA enabled device
	cudaDeviceProp bestDeviceProp;
	int bestDeviceIndx = 0;
	cuda_error = cudaGetDeviceProperties(&bestDeviceProp, bestDeviceIndx);
	if (cuda_error != cudaSuccess)
		throw Exception("Failed to get device properties.");
	for (int deviceIndx = 1; deviceIndx < deviceCount; deviceIndx++)
	{
		cudaDeviceProp deviceProp;
		cuda_error = cudaGetDeviceProperties(&deviceProp, 0);
		if (cuda_error != cudaSuccess)
			throw Exception("Failed to get device properties.");

		if (bestDeviceProp.major < deviceProp.major)
			bestDeviceIndx = deviceIndx;
		else if (bestDeviceProp.major == deviceProp.major)
			if(bestDeviceProp.clockRate < deviceProp.clockRate)
				bestDeviceIndx = deviceIndx;
	}
	cuda_error = cudaGetDeviceProperties(&bestDeviceProp, bestDeviceIndx);
	if (cuda_error != cudaSuccess)
		throw Exception("Failed to get device properties.");

	cuda_error = cudaSetDevice(bestDeviceIndx);
	if (cuda_error != cudaSuccess)
		throw Exception("Failed to set CUDA device.");

	// Gettin device driver version
	int driverVersion = 0;
	cuda_error = cudaDriverGetVersion(&driverVersion);
	if (cuda_error != cudaSuccess)
		throw Exception("Failed to get device driver version.");
	_val(driver_version) = driverVersion / 1000 + (driverVersion % 100) / 100.0f;
	// Gettin device driver version
	int runtimeVersion = 0;
	cuda_error = cudaRuntimeGetVersion(&runtimeVersion);
	if (cuda_error != cudaSuccess)
		throw Exception("Failed to get device runtime version.");
	_val(runtime_version) = driverVersion / 1000.0f + (driverVersion % 100) / 100.0f;

	// Gettin device properties
	try {
		_val(device) = bestDeviceIndx;
		strcpy(name, bestDeviceProp.name);
		_val(capability_version) = (float)bestDeviceProp.major + (bestDeviceProp.minor) / 10.f;
		_val(global_memory) = bestDeviceProp.totalGlobalMem / 1048576.0f;
		_val(memory_clock_rate) = bestDeviceProp.memoryClockRate;
		_val(multyprocessors_num) = bestDeviceProp.multiProcessorCount;
		_val(memory_bus_width) = bestDeviceProp.memoryBusWidth;
		_val(cuda_cores_num) = _ConvertSMVer2Cores(bestDeviceProp.major, bestDeviceProp.minor) * bestDeviceProp.multiProcessorCount;
		_val(clock_rate) = bestDeviceProp.clockRate;
	}
	catch (...)
	{
		throw Exception("Failed to get CUDA device properties.");
	}
}


extern "C" int _declspec(dllexport) _stdcall CUDA_DeviceNum()
{
	return 10;
}