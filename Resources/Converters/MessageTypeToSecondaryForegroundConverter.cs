using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class MessageTypeToSecondaryForegroundConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        /*
        var resources = System.Windows.Application.Current.Resources;

        return (MessageType?)value switch
        {
            MessageType.Success => resources.Get("OrnamentalBorder-SolidColorBrush"),
            MessageType.Error => resources.Get("OrnamentalBorder-SolidColorBrush"),
            MessageType.Warning => resources.Get("BrandGray-SolidColorBrush-0"),
            MessageType.Information => resources.Get("OrnamentalBorder-SolidColorBrush"),
            _ => resources.Get("OrnamentalBorder-SolidColorBrush")
        };
        */
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
