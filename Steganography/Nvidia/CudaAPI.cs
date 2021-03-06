﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography.Nvidia
{
    public class CudaAPI
    {
        public static CudaDeviceInfo Device { get; set; } = null;

        public static bool CheckIsCudaAvailable()
        {
            try
            {
                return CUDA_Check();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static CudaDeviceInfo GetBestDeviceInfo()
        {
            CudaDeviceInfo device = null;
            try
            {
                int index = 0;
                StringBuilder name = new StringBuilder(255);
                float driver_version = 0;
                float runtime_version = 0;
                float capability_version = 0;
                int global_memory = 0;
                int memory_clock_rate = 0;
                int multyprocessors_num = 0;
                int memory_bus_width = 0;
                int cuda_cores_num = 0;
                int clock_rate = 0;
                CUDA_BestDeviceInfo(ref index, name, ref driver_version, ref runtime_version, ref capability_version, ref global_memory, ref memory_clock_rate, ref multyprocessors_num, ref memory_bus_width, ref cuda_cores_num, ref clock_rate);
                return device = new CudaDeviceInfo
                {
                    Index = index,
                    Name = name.ToString(),
                    DriverVersion = driver_version,
                    RuntimeVersion = runtime_version,
                    CapabilityVersion = capability_version,
                    GlobalMemory = global_memory,
                    MemoryClockRate = memory_clock_rate,
                    MultyprocessorsNum = multyprocessors_num,
                    MemoryBusWidth = memory_bus_width,
                    CudaCoresNum = cuda_cores_num,
                    ClockRate = clock_rate
                };
            }
            catch (Exception)
            {
                throw new Exception(GetLastExceptionMessage());
            }
        }

        public static void SetBestDevice()
        {
            Device = GetBestDeviceInfo();
        }

        public static void CalculateAutoCorrelation(byte[] imageBytesOriginal, byte[] imageBytesPacked, int[] returnData)
        {
            if (Device == null)
            {
                throw new Exception("CUDA API not initialized!");
            }
            try
            {
                CUDA_CalculateAutoCorrelation(imageBytesOriginal, imageBytesOriginal.Length, imageBytesPacked, imageBytesPacked.Length, returnData);
            }
            catch (Exception e)
            {

            }
        }

        public static void PackBytes(byte[] imageBytes, byte[] fileBytes)
        {
            if (Device == null)
            {
                throw new Exception("CUDA API not initialized!");
            }
            try
            {
                CUDA_PackBytes(imageBytes, imageBytes.Length, fileBytes, fileBytes.Length);
            }
            catch (Exception e)
            {

            }
        }

        public static void UnpackBytes(byte[] imageBytes, byte[] fileBytes)
        {
            if (Device == null)
            {
                throw new Exception("CUDA API not initialized!");
            }
            try
            {
                CUDA_UnpackBytes(imageBytes, imageBytes.Length, fileBytes, fileBytes.Length);
            }
            catch (Exception e)
            {

            }
        }

        #region DLL functions

        private static string GetLastExceptionMessage()
        {
            StringBuilder message = new StringBuilder(255);
            GetLastException(message);
            return message.ToString();
        }

        [DllImport("SteganographyCuda.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void GetLastException(StringBuilder exception);

        [DllImport("SteganographyCuda.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool CUDA_Check();

        [DllImport("SteganographyCuda.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void CUDA_BestDeviceInfo(
            ref int device,
            StringBuilder name,
            ref float driver_version,
            ref float runtime_version,
            ref float capability_version,
            ref int global_memory,
            ref int memory_clock_rate,
            ref int L2_cash_size,
            ref int memory_bus_width,
            ref int cuda_cores_num,
            ref int clock_rate
        );

        [DllImport("SteganographyCuda.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void CUDA_CalculateAutoCorrelation(byte[] imageBytesOriginal, int imageBytesOriginalLength, byte[] imageBytesPacked, int imageBytesPackedLength, int[] returnData);

        [DllImport("SteganographyCuda.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void CUDA_PackBytes(byte[] imageBytes, int imageBytesLength, byte[] fileBytes, int fileBytesLength);

        [DllImport("SteganographyCuda.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void CUDA_UnpackBytes(byte[] imageBytes, int imageBytesLength, byte[] fileBytes, int fileBytesLength);

        #endregion
    }
}
