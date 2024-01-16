using Avalonia.Platform;
#if !WINDOWS
using Avalonia.Controls;
using Avalonia.Controls.Platform;
using Avalonia.X11.Interop;
using Gtk;
#endif

namespace IsoniaCore.Native.PolyFills
{
    public static class HandleBuilder
    {
#if !WINDOWS
        private static ControlWrapper? CreateHandleImpl(object obj)
        {
            if (obj is Gtk.Window window)
            {
                if (!window.IsVisible)
                {
                    window.Show();
                }
                return new ControlWrapper(window);
            }
            else if (obj is Widget widget)
            {
                if (widget.Window == null || widget.Window.Handle == IntPtr.Zero)
                {
                    Gtk.Window win = new Gtk.Window(WindowType.Toplevel);

                    win.DestroyEvent += Win_DestroyEvent;
                    win.Destroyed += Win_Destroyed;
                    win.Add(widget);
                    win.Show();
                }

                return new ControlWrapper(widget);
            }

            return null;
        }

        private static void Win_DestroyEvent(object o, DestroyEventArgs args)
        {
           
        }

        private static void Win_Destroyed(object? sender, EventArgs e)
        {
            
        }
#endif

        public static IPlatformHandle? BuildHandle(object obj)
        {
#if WINDOWS
            if (obj is IntPtr windowHandle)
            {
                return new PlatformHandle(windowHandle, "Isonia");
            }
            return null;
#else
            IPlatformHandle? handle = GtkInteropHelper.RunOnGlibThread(() =>
            {
                return CreateHandleImpl(obj);
            }).Result;

            return handle;
#endif
        }

        public static IPlatformHandle? BuildObjAndHandle(Func<object> objBuilder)
        {
#if WINDOWS
            object obj = objBuilder();
            return BuildHandle(obj);
#else
            IPlatformHandle? handle = GtkInteropHelper.RunOnGlibThread(() =>
            {
                object obj = objBuilder();
                ControlWrapper? controlWrapper = CreateHandleImpl(obj);

                return controlWrapper;
            }).Result;

            return handle;
#endif
        }

        public static void DestroyHandle(this IPlatformHandle? platformHandle)
        {
            if (platformHandle == null)
                return;
#if WINDOWS
            WinApi.DestroyIsoniaWindow(platformHandle.Handle);
#else
            ((INativeControlHostDestroyableControlHandle)platformHandle).Destroy();
#endif
        }
    }

#if !WINDOWS
    // Control wrapper stores the original widget's (or gkt window's) handle 
    // to be destroyed when the window is released (instead of X11 handle)
    class ControlWrapper : INativeControlHostDestroyableControlHandle
    {
        private readonly IntPtr _widgetHandle;

        public IntPtr Handle { get; }

        private Gdk.Window Window { get; }

        public ControlWrapper(Gtk.Widget widget)
        {
            _widgetHandle = widget.Handle;

            Window = widget.Window;

            Handle = GtkHelper.gdk_x11_window_get_xid(widget.Window.Handle);

            if (!Window.IsVisible)
            {
                Window.Show();
            }
        }

        public string? HandleDescriptor => "XID";

        public void Destroy()
        {
            GtkInteropHelper.RunOnGlibThread(() =>
            {
                GtkHelper.gtk_widget_destroy(_widgetHandle);
                return 0;
            }).Wait();
        }
    }
#endif
}
