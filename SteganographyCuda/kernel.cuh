#pragma once


__global__ void packBits(unsigned char* inData, int numIn, unsigned char* outData, int numOut)
{
	__shared__ unsigned int sharedData[64];

	int threadIndex = threadIdx.x * blockDim.y + threadIdx.y;
	int inIndex = blockIdx.x * blockDim.x + threadIdx.x;
	int outIndex = blockIdx.x * blockDim.x * blockDim.y + threadIndex;

	if (outIndex < numOut && inIndex < numIn)
	{
		if (threadIdx.y == 0)
		{
			sharedData[threadIdx.x] = (unsigned int)(inData[inIndex]);
		}

		__syncthreads();

		outData[outIndex] = (unsigned char)((((unsigned int)(outData[outIndex]) >> 1) << 1) | (sharedData[threadIdx.x] << (24 + threadIdx.y) >> 31));
	}
}

__global__ void unpackBits(unsigned char* inData, int numIn, unsigned char* outData, int numOut)
{
	__shared__ unsigned char sharedData[512];

	int threadIndex = threadIdx.x * blockDim.y + threadIdx.y;
	int inIndex = blockIdx.x * blockDim.x * blockDim.y + threadIndex;
	int outIndex = blockIdx.x * blockDim.x + threadIdx.x;

	if (outIndex < numOut && inIndex < numIn)
	{
		sharedData[threadIndex] = (unsigned char)(((unsigned int)(inData[inIndex]) << 31) >> (24 + threadIdx.y));

		__syncthreads();

		for (unsigned int stride = 4; stride > 0; stride >>= 1)
		{
			if (threadIdx.y < stride)
			{
				sharedData[threadIndex] |= sharedData[threadIndex + stride];
			}
			__syncthreads();
		}

		if (threadIdx.y == 0)
		{
			outData[outIndex] = sharedData[threadIndex];
		}
	}
}



__global__ void extractBits(unsigned char* inData, int numIn, int* outData, int numOut)
{
	int outIndex = blockIdx.x * blockDim.x + threadIdx.x;
	int inIndex = outIndex * 8;

	if (outIndex < numOut && inIndex < numIn)
	{
		outData[outIndex] = (int)((unsigned char)((unsigned int)(inData[inIndex]) << 7));
	}
}


__global__ void
vectorSquare(int* array, const int numElements)
{
	int i = blockDim.x * blockIdx.x + threadIdx.x;

	if (i < numElements)
	{
		array[i] = array[i] * array[i];
	}
}

__global__ void
vectorMultiplyScalar(int* array, const int numElements, const int scalar)
{
	int i = blockDim.x * blockIdx.x + threadIdx.x;

	if (i < numElements)
	{
		array[i] = array[i] * scalar;
	}
}

__global__ void
vectorSubstraction(int* original, const int* packed, int numElements)
{
	int i = blockDim.x * blockIdx.x + threadIdx.x;

	if (i < numElements)
	{
		original[i] = original[i] - packed[i];
	}
}