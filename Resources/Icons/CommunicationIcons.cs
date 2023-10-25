using IsoniaCore.Utilities;
using Avalonia.Media;
using Avalonia;

namespace IsoniaCore.Resources.Icons;

public static partial class Icons
{
    private static StreamGeometry? copyIcon;
    public static StreamGeometry? CopyIcon => copyIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(CopyIcon));
}