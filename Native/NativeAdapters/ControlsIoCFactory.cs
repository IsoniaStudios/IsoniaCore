using Avalonia.Platform;
using IsoniaCore.Native.PolyFills;

namespace IsoniaCore.Native.NativeAdapters
{
    public static class ControlsIoCFactory
    {
        public static IPlatformHandle? CreateIsoniaView()
        {
#if WINDOWS
            return WindowsControlsIoCFactory.CreateIsoniaView();
#elif MACOS
            return null;
#elif LINUX
            return LinuxControlsIoCFactory.CreateIsoniaView();
#else
        throw new NotSupportedException("Platform not supported");
#endif
        }
    }
}
