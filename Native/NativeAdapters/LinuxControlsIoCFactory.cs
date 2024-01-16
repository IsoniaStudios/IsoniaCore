#if !WINDOWS
using Avalonia.Platform;
using NP.DependencyInjection.Attributes;

namespace IsoniaCore.Native.NativeAdapters
{
    public static class LinuxControlsIoCFactory
    {
        public static IPlatformHandle? CreateIsoniaView()
        {
            // HandleBuilder.BuildObjAndHandle will run the LinuxView and IPlatformHandle creation code 
            //return HandleBuilder.BuildObjAndHandle(() => new LinuxView());
            return null;
        }
    }
}
#endif
