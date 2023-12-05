using IsoniaCore.Utilities;
using Avalonia.Media;
using Avalonia;

namespace IsoniaCore.Resources.Icons;

public static partial class IconStore
{
    private static StreamGeometry? projectIcon;
    private static StreamGeometry? installIcon;
    private static StreamGeometry? deleteIcon;
    private static StreamGeometry? saveIcon;
    private static StreamGeometry? saveAsIcon;

    public static StreamGeometry? ProjectIcon => projectIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(ProjectIcon));
    public static StreamGeometry? InstallIcon => installIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(InstallIcon));
    public static StreamGeometry? DeleteIcon => deleteIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(DeleteIcon));
    public static StreamGeometry? SaveIcon => saveIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(SaveIcon));
    public static StreamGeometry? SaveAsIcon => saveAsIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(SaveAsIcon));
}