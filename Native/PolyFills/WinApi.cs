#if WINDOWS
using System.Runtime.InteropServices;

namespace IsoniaCore.Native.PolyFills
{
    public static unsafe class WinApi
    {
        private const string libPath = "Isonia.dll";

        [DllImport(libPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Isonia_CreateIsoniaWindow();

        [DllImport(libPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Isonia_DestroyIsoniaWindow(IntPtr windowHandle);
    }
}
#endif
