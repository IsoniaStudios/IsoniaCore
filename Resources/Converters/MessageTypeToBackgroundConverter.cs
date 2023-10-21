using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class MessageTypeToBackgroundConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        /*
        var resources = System.Windows.Application.Current.Resources;

        return (MessageType?)value switch
        {
            MessageType.Success => resources.Get("AlertSuccess-SolidColorBrush"),
            MessageType.Error => resources.Get("AlertError-SolidColorBrush"),
            MessageType.Warning => resources.Get("AlertWarning-SolidColorBrush"),
            MessageType.Information => resources.Get("BlueAccent-SolidColorBrush"),
            _ => resources.Get("BluePrimary-SolidColorBrush")
        };
        */
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
