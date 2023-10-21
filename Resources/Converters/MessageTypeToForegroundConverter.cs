using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class MessageTypeToForegroundConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        /*
        var resources = System.Windows.Application.Current.Resources;

        return (MessageType?)value switch
        {
            MessageType.Success => resources.Get("BrandWhite-SolidColorBrush"),
            MessageType.Error => resources.Get("BrandWhite-SolidColorBrush"),
            MessageType.Warning => resources.Get("BrandBlack-SolidColorBrush-0"),
            MessageType.Information => resources.Get("BrandWhite-SolidColorBrush"),
            _ => resources.Get("BrandWhite-SolidColorBrush")
        };
        */
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
