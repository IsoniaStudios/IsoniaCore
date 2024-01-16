#if WINDOWS
using Avalonia.Platform;
using IsoniaCore.Native.PolyFills;
using NP.DependencyInjection.Attributes;

namespace IsoniaCore.Native.NativeAdapters
{
    [HasRegisterMethods]
    public static class WindowsControlsIoCFactory
    {
        [RegisterMethod(typeof(IPlatformHandle), resolutionKey: "CreateIsoniaView")]
        public static IPlatformHandle? CreateIsoniaView()
        {
            // Call the C++ function to create the isonia window
            IntPtr glfwWindowHandle = WinApi.CreateIsoniaWindow();

            // use the method from PolyFill project to create the platform handle
            return HandleBuilder.BuildHandle(glfwWindowHandle);
        }
    }
}
#endif
