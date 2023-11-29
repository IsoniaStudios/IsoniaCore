using Avalonia.Media.Fonts;

namespace IsoniaCore.Resources.Fonts;

public sealed class FontsCollection : EmbeddedFontCollection
{
    public FontsCollection() : base(
        new Uri("fonts:Inter", UriKind.Absolute),
        new Uri("avares://Avalonia.Fonts.Inter/Assets", UriKind.Absolute))
    {
    }
}
