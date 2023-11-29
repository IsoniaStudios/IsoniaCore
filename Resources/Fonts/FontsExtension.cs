using Avalonia;

namespace IsoniaCore.Resources.Fonts;

public static class FontsExtension
{
    public static AppBuilder WithFont(this AppBuilder appBuilder)
    {
        return appBuilder.ConfigureFonts(fontManager =>
        {
            fontManager.AddFontCollection(new FontsCollection());
        });
    }
}
