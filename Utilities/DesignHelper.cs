using System.Diagnostics;
using Avalonia.Controls;

namespace IsoniaCore.Utilities;

public static class DesignHelper
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The datacontext type</typeparam>
    /// <param name="control">The control to set the datacontext of</param>
    /// <param name="editAction"></param>
    [Conditional("DEBUG")]
    public static void SetDesignContext<T>(this Control control, Action<T> editAction) where T : new()
    {
        if (!Design.IsDesignMode)
            return;

        if (control.DataContext is not null)
            return;

        T vm = new();
        editAction(vm);
        control.DataContext = vm;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The datacontext type</typeparam>
    /// <param name="control">The control to set the datacontext of</param>
    [Conditional("DEBUG")]
    public static void SetDesignContext<T>(this Control control) where T : new()
    {
        if (!Design.IsDesignMode)
            return;

        if (control.DataContext is not null)
            return;

        T vm = new();
        control.DataContext = vm;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The datacontext type</typeparam>
    /// <param name="control"></param>
    /// <param name="editAction"></param>
    [Conditional("DEBUG")]
    public static void OverrideDesignContext<T>(this Control control, Action<T> editAction) where T : new()
    {
        control.Loaded += (sender, e) => control.SetDesignContext<T>(editAction);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The datacontext type</typeparam>
    /// <param name="control"></param>
    [Conditional("DEBUG")]
    public static void OverrideDesignContext<T>(this Control control) where T : new()
    {
        control.Loaded += (sender, e) => control.SetDesignContext<T>();
    }
}
