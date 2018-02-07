#pragma once
#ifndef FWT_KERNEL_CUH
#define FWT_KERNEL_CUH
#ifndef fwt_kernel_cuh
#define fwt_kernel_cuh

#include <cooperative_groups.h>


///////////////////////////////////////////////////////////////////////////////
// Elementary(for vectors less than elementary size) in-shared memory
// combined radix-2 + radix-4 Fast Walsh Transform
///////////////////////////////////////////////////////////////////////////////
#define ELEMENTARY_LOG2SIZE 11

__global__ void fwtBatch1Kernel(int *d_Output, int *d_Input, int log2N)
{
	// Handle to thread block group
	cooperative_groups::thread_block cta = cooperative_groups::this_thread_block();
	const int    N = 1 << log2N;
	const int base = blockIdx.x << log2N;

	//(2 ** 11) * 4 bytes == 8KB -- maximum s_data[] size for G80
	extern __shared__ int s_data[];
	int *d_Src = d_Input + base;
	int *d_Dst = d_Output + base;

	for (int pos = threadIdx.x; pos < N; pos += blockDim.x)
	{
		s_data[pos] = d_Src[pos];
	}

	//Main radix-4 stages
	const int pos = threadIdx.x;

	for (int stride = N >> 2; stride > 0; stride >>= 2)
	{
		int lo = pos & (stride - 1);
		int i0 = ((pos - lo) << 2) + lo;
		int i1 = i0 + stride;
		int i2 = i1 + stride;
		int i3 = i2 + stride;

		cooperative_groups::sync(cta);
		int D0 = s_data[i0];
		int D1 = s_data[i1];
		int D2 = s_data[i2];
		int D3 = s_data[i3];

		int T;
		T = D0;
		D0 = D0 + D2;
		D2 = T - D2;
		T = D1;
		D1 = D1 + D3;
		D3 = T - D3;
		T = D0;
		s_data[i0] = D0 + D1;
		s_data[i1] = T - D1;
		T = D2;
		s_data[i2] = D2 + D3;
		s_data[i3] = T - D3;
	}

	//Do single radix-2 stage for odd power of two
	if (log2N & 1)
	{
		cooperative_groups::sync(cta);

		for (int pos = threadIdx.x; pos < N / 2; pos += blockDim.x)
		{
			int i0 = pos << 1;
			int i1 = i0 + 1;

			int D0 = s_data[i0];
			int D1 = s_data[i1];
			s_data[i0] = D0 + D1;
			s_data[i1] = D0 - D1;
		}
	}

	cooperative_groups::sync(cta);

	for (int pos = threadIdx.x; pos < N; pos += blockDim.x)
	{
		d_Dst[pos] = s_data[pos];
	}
}

////////////////////////////////////////////////////////////////////////////////
// Single in-global memory radix-4 Fast Walsh Transform pass
// (for strides exceeding elementary vector size)
////////////////////////////////////////////////////////////////////////////////
__global__ void fwtBatch2Kernel(
	int *d_Output,
	int *d_Input,
	int stride
)
{
	const int pos = blockIdx.x * blockDim.x + threadIdx.x;
	const int   N = blockDim.x *  gridDim.x * 4;

	int *d_Src = d_Input + blockIdx.y * N;
	int *d_Dst = d_Output + blockIdx.y * N;

	int lo = pos & (stride - 1);
	int i0 = ((pos - lo) << 2) + lo;
	int i1 = i0 + stride;
	int i2 = i1 + stride;
	int i3 = i2 + stride;

	int D0 = d_Src[i0];
	int D1 = d_Src[i1];
	int D2 = d_Src[i2];
	int D3 = d_Src[i3];

	int T;
	T = D0;
	D0 = D0 + D2;
	D2 = T - D2;
	T = D1;
	D1 = D1 + D3;
	D3 = T - D3;
	T = D0;
	d_Dst[i0] = D0 + D1;
	d_Dst[i1] = T - D1;
	T = D2;
	d_Dst[i2] = D2 + D3;
	d_Dst[i3] = T - D3;
}

////////////////////////////////////////////////////////////////////////////////
// Put everything together: batched Fast Walsh Transform CPU front-end
////////////////////////////////////////////////////////////////////////////////
void fwtBatchGPU(int *d_Data, int M, int log2N)
{
	const int THREAD_N = 256;

	int N = 1 << log2N;
	dim3 grid((1 << log2N) / (4 * THREAD_N), M, 1);

	for (; log2N > ELEMENTARY_LOG2SIZE; log2N -= 2, N >>= 2, M <<= 2)
	{
		fwtBatch2Kernel << <grid, THREAD_N >> >(d_Data, d_Data, N / 4);
		//getLastCudaError("fwtBatch2Kernel() execution failed\n");
	}

	fwtBatch1Kernel << <M, N / 4, N * sizeof(int) >> >(
		d_Data,
		d_Data,
		log2N
		);
	//getLastCudaError("fwtBatch1Kernel() execution failed\n");
}

#endif
#endif
