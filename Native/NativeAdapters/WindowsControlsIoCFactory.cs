#if WINDOWS
using Avalonia.Platform;
using IsoniaCore.Native.PolyFills;

namespace IsoniaCore.Native.NativeAdapters
{
    public static class WindowsControlsIoCFactory
    {
        public static IPlatformHandle? CreateIsoniaView()
        {
            // Call the C++ function to create the isonia window
            IntPtr glfwWindowHandle = WinApi.CreateIsoniaWindow();
            WinApi.Run();
            // use the method from PolyFill project to create the platform handle
            return HandleBuilder.BuildHandle(glfwWindowHandle);
        }
    }
}
#endif
