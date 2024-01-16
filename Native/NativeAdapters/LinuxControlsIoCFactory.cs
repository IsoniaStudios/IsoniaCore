#if !WINDOWS
using Avalonia.Platform;
using NP.DependencyInjection.Attributes;

namespace IsoniaCore.Native.NativeAdapters
{
    [HasRegisterMethods]
    public static class LinuxControlsIoCFactory
    {
        [RegisterMethod(typeof(IPlatformHandle), resolutionKey: "CreateIsoniaView")]
        public static IPlatformHandle? CreateIsoniaView()
        {
            // HandleBuilder.BuildObjAndHandle will run the LinuxView and IPlatformHandle creation code 
            //return HandleBuilder.BuildObjAndHandle(() => new LinuxView());
            return null;
        }
    }
}
#endif
