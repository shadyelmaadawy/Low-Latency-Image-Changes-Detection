using System;
using System.Runtime.InteropServices;

namespace Low_Latency_Image_Changes_Detection
{
    internal class NativeAPIs
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int memcmp(IntPtr b1, IntPtr b2, IntPtr count);

    }
}
