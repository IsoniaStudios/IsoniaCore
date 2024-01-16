using Avalonia;
using Avalonia.Controls;
using Avalonia.Platform;
using IsoniaCore.Native.PolyFills;

namespace IsoniaCore.Native.Visuals
{
    public class NativeEmbeddingControl : NativeControlHost
    {
        public NativeEmbeddingControl(IPlatformHandle? handle)
        {
            Handle = handle;
        }

        public IPlatformHandle? Handle
        {
            get => GetValue(HandleProperty);
            set => SetValue(HandleProperty, value);
        }

        public static readonly StyledProperty<IPlatformHandle?> HandleProperty = AvaloniaProperty.Register<NativeEmbeddingControl, IPlatformHandle?>(nameof(Handle));

        protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle? parent)
        {
            if (Handle != null)
            {
                // if handle property is not null, return it
                return Handle;
            }
         
            return base.CreateNativeControlCore(parent!);
        }

        protected override void DestroyNativeControlCore(IPlatformHandle? handle)
        {
            // call extension method HandleBuilder.DestroyHandle() of PolyFill project
            handle.DestroyHandle();
        }
    }
}
