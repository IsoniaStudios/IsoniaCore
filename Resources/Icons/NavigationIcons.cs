using IsoniaCore.Utilities;
using Avalonia.Media;
using Avalonia;

namespace IsoniaCore.Resources.Icons;

public static partial class IconStore
{
    private static StreamGeometry? folderIcon;
    private static StreamGeometry? fileIcon;
    public static StreamGeometry? FolderIcon => folderIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(FolderIcon));
    public static StreamGeometry? FileIcon => fileIcon ??= Application.Current?.Resources.GetResource<StreamGeometry>(nameof(FileIcon));
}