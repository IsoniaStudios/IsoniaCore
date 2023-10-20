using System.Globalization;
using Avalonia.Media;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class RandomColorConverter : IValueConverter
{
    /// <summary>
    /// The current color index.
    /// </summary>
    private static int currentHighContrastColorIndex = 0;

    /// <summary>
    /// Gets or sets the default colors.
    /// </summary>
    /// <value>The default colors.</value>
    private static readonly Color[] HighContrastColors = new Color[]
    {
        Color.FromRgb(230, 25, 75),
        Color.FromRgb(60, 180, 75),
        Color.FromRgb(255, 225, 25),
        Color.FromRgb(0, 130, 200),
        Color.FromRgb(245, 130, 48),
        Color.FromRgb(145, 30, 180),
        Color.FromRgb(70, 240, 240),
        Color.FromRgb(240, 50, 230),
        Color.FromRgb(210, 245, 60),
        Color.FromRgb(250, 190, 212),
        Color.FromRgb(0, 128, 128),
        Color.FromRgb(220, 190, 255),
        Color.FromRgb(170, 110, 40),
        Color.FromRgb(255, 250, 200),
        Color.FromRgb(128, 0, 0),
        Color.FromRgb(170, 255, 195),
        Color.FromRgb(128, 128, 0),
        Color.FromRgb(255, 215, 180),
        Color.FromRgb(0, 0, 128)
    };

    /// <summary>
    /// Gets the default color from the DefaultColors palette.
    /// </summary>
    /// <returns>The next default color.</returns>
    public static Color GetNextHighContrastColor()
    {
        return HighContrastColors[currentHighContrastColorIndex++ % HighContrastColors.Length];
    }

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        // Get next high contrast color
        Color color = GetNextHighContrastColor();

        // Create a new SolidColorBrush using the random color
        return new SolidColorBrush(color);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
