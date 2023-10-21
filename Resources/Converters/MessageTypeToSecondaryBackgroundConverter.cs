using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class MessageTypeToSecondaryBackgroundConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        /*
        var resources = System.Windows.Application.Current.Resources;

        return (MessageType?)value switch
        {
            MessageType.Success => resources.Get("AlertSuccessAccent-SolidColorBrush"),
            MessageType.Error => resources.Get("AlertErrorAccent-SolidColorBrush"),
            MessageType.Warning => resources.Get("AlertWarningAccent-SolidColorBrush"),
            MessageType.Information => resources.Get("BrandBlue-SolidColorBrush-2"),
            _ => resources.Get("BlueAccent-SolidColorBrush")
        };
        */
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
