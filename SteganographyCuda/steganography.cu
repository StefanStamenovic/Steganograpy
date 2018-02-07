	#include <stdio.h>
#include <string>
#include "cuda_runtime.h"
#include "kernel.cuh"
#include "fwhtKernel.cuh"

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
	Exception(const char* message, cudaError_t error) {
		if (this->message != NULL)
			delete this->message;
		const char* cudaErrorMessage = cudaGetErrorString(error);
		this->message = NULL;
		this->message = new char[strlen(message) + strlen(cudaErrorMessage) + 1];
		strcpy(this->message, message);
		strcpy(&(this->message[strlen(message)]), cudaErrorMessage);
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



///////////////////////////////////////////////////////////////////
// Autocorrelation
///////////////////////////////////////////////////////////////////


extern "C" void _declspec(dllexport) _stdcall CUDA_PackBytes(unsigned char* imageBytes, int imageBytesLength, unsigned char* fileBytes, int fileBytesLength)
throw (char*)
{
	cudaError_t err = cudaSuccess;

	size_t sizeIn = fileBytesLength * sizeof(unsigned char);
	size_t sizeOut = imageBytesLength * sizeof(unsigned char);

	unsigned char* d_inData;
	err = cudaMalloc((void**)&d_inData, sizeIn);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_inData, fileBytes, sizeIn, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	unsigned char* d_outData;
	err = cudaMalloc((void**)&d_outData, sizeOut);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_outData, imageBytes, sizeOut, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	int threadsPerBlock = 512;
	int blocksPerGrid = (int)((fileBytesLength * 8 + threadsPerBlock - 1) / threadsPerBlock);
	dim3 threadsPerBlockDim(64, 8);
	packBits << <blocksPerGrid, threadsPerBlockDim >> >(d_inData, fileBytesLength, d_outData, imageBytesLength);

	cudaMemcpy(imageBytes, d_outData, sizeOut, cudaMemcpyDeviceToHost);

	cudaFree(d_inData);
	cudaFree(d_outData);
}

extern "C" void _declspec(dllexport) _stdcall CUDA_UnpackBytes(unsigned char* imageBytes, int imageBytesLength, unsigned char* fileBytes, int fileBytesLength)
throw (char*)
{
	cudaError_t err = cudaSuccess;

	size_t sizeOut = fileBytesLength * sizeof(unsigned char);
	size_t sizeIn = imageBytesLength * sizeof(unsigned char);

	unsigned char* d_inData;
	err = cudaMalloc((void**)&d_inData, sizeIn);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_inData, imageBytes, sizeIn, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	unsigned char* d_outData;
	err = cudaMalloc((void**)&d_outData, sizeOut);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_outData, fileBytes, sizeOut, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	int threadsPerBlock = 512;
	int blocksPerGrid = (int)((fileBytesLength * 8 + threadsPerBlock - 1) / threadsPerBlock);
	dim3 threadsPerBlockDim(64, 8);
	unpackBits << <blocksPerGrid, threadsPerBlockDim >> >(d_inData, imageBytesLength, d_outData, fileBytesLength);

	cudaMemcpy(fileBytes, d_outData, sizeOut, cudaMemcpyDeviceToHost);

	cudaFree(d_inData);
	cudaFree(d_outData);
}

void CalculateAutoCorrelation(unsigned char* imageBytes, int imageBytesLength, int** autoCorrelation, int* autoCorrelationLength);

extern "C" void main()
{

}

extern "C" void _declspec(dllexport) _stdcall CUDA_CalculateAutoCorrelation(unsigned char* imageBytesOriginal, int imageBytesOriginalLength, unsigned char* imageBytesPacked, int imageBytesPackedLength, int* returnData)
{
	cudaError_t err = cudaSuccess;
	
	int* originalAutoCorr;
	int originalAutoCorrLength;

	int * packedAutoCorr;
	int packedAutoCorrLength;

	CalculateAutoCorrelation(imageBytesOriginal, imageBytesOriginalLength, &originalAutoCorr, &originalAutoCorrLength);
	CalculateAutoCorrelation(imageBytesPacked, imageBytesPackedLength, &packedAutoCorr, &packedAutoCorrLength);

	size_t sizeOut = packedAutoCorrLength * sizeof(int);
	size_t sizeIn = originalAutoCorrLength * sizeof(int);

	int* h_retData = (int *)malloc(sizeIn);
	memset(h_retData, 0, sizeIn);

	int* d_inData;
	err = cudaMalloc((void**)&d_inData, sizeIn);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_inData, originalAutoCorr, sizeIn, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	int* d_outData;
	err = cudaMalloc((void**)&d_outData, sizeOut);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_outData, packedAutoCorr, sizeOut, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	int threadsPerBlock = 512;
	int blocksPerGrid = (int)((originalAutoCorrLength + threadsPerBlock - 1) / threadsPerBlock);
	vectorSubstraction << <blocksPerGrid, threadsPerBlock >> >(d_inData, d_outData, originalAutoCorrLength);

	err = cudaMemcpy(h_retData, d_inData, sizeIn, cudaMemcpyDeviceToHost);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from device to host - error code: ", err);
	}

	cudaFree(d_inData);
	cudaFree(d_outData);

	memcpy(returnData, h_retData, sizeIn);
	free(h_retData);
}

void CalculateAutoCorrelation(unsigned char* imageBytes, int imageBytesLength, int** autoCorrelation, int* autoCorrelationLength)
{
	cudaError_t err = cudaSuccess;

	int logLength = (int)ceil(log2(imageBytesLength / 8));
	int outLength = 1 << logLength;
	*autoCorrelationLength = outLength;

	size_t sizeIn = imageBytesLength * sizeof(unsigned char);
	size_t sizeOut = outLength * sizeof(int);

	int* h_outData = (int *)malloc(sizeOut);
	memset(h_outData, 0, sizeOut);

	unsigned char* d_inData;
	err = cudaMalloc((void**)&d_inData, sizeIn);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_inData, imageBytes, sizeIn, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	int* d_outData;
	err = cudaMalloc((void**)&d_outData, sizeOut);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to allocate device vector - error code: ", err);
	}

	err = cudaMemcpy(d_outData, h_outData, sizeOut, cudaMemcpyHostToDevice);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from host to device - error code: ", err);
	}

	int threadsPerBlock = 512;
	int blocksPerGrid = (int)((outLength + threadsPerBlock - 1) / threadsPerBlock);
	extractBits << <blocksPerGrid, threadsPerBlock >> >(d_inData, imageBytesLength, d_outData, outLength);
	
	fwtBatchGPU(d_outData, 1, logLength);
	vectorSquare << <blocksPerGrid, threadsPerBlock >> >(d_outData, outLength);
	fwtBatchGPU(d_outData, 1, logLength);
	vectorMultiplyScalar << <blocksPerGrid, threadsPerBlock >> >(d_outData, outLength, logLength);
	
	err = cudaMemcpy(h_outData, d_outData, sizeOut, cudaMemcpyDeviceToHost);
	if (err != cudaSuccess)
	{
		throw Exception("Failed to copy vector from device to host - error code: ", err);
	}

	cudaFree(d_inData);
	cudaFree(d_outData);

	*autoCorrelation = h_outData;
}