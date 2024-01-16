#if WINDOWS
using System.Runtime.InteropServices;

namespace IsoniaCore.Native.PolyFills
{
    public static unsafe class WinApi
    {
        [DllImport("Isonia.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreateIsoniaWindow();

        [DllImport("Isonia.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyIsoniaWindow(IntPtr windowHandle);
    }
}
#endif
