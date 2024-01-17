#if WINDOWS
using System.Runtime.InteropServices;

namespace IsoniaCore.Native.PolyFills
{
    public static unsafe class WinApi
    {
        private const string dllPath = "Isonia.dll";
        private const string pdbPath = "Isonia.pdb";

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public static extern IntPtr CreateIsoniaWindow();

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public static extern void DestroyIsoniaWindow(IntPtr windowHandle);

        [DllImport(dllPath, CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        public static extern void Run();
    }
}
#endif
