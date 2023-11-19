using IsoniaCore.Utilities;
using Avalonia.Media;
using Avalonia;

namespace IsoniaCore.Resources.Icons;

public static partial class IconStore
{
    private static StreamGeometry? openFolderIcon;
    private static StreamGeometry? folderIcon;
    public static StreamGeometry? OpenFolderIcon => openFolderIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(OpenFolderIcon));
    public static StreamGeometry? FolderIcon => folderIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(FolderIcon));
}