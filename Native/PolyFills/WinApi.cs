#if WINDOWS
using System.Runtime.InteropServices;

namespace IsoniaCore.Native.PolyFills
{
    public static unsafe class WinApi
    {
        private const string libPath = "C:\\Source\\IsoniaStudios\\Isonia\\out\\build\\x64-debug\\Isonia\\Isonia.dll";

        [DllImport(libPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CreateIsoniaWindow();

        [DllImport(libPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyIsoniaWindow(IntPtr windowHandle);

        [DllImport(libPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Run();
    }
}
#endif
