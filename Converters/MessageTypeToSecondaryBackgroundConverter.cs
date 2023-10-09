using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Converters
{
    public class MessageTypeToSecondaryBackgroundConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            /*
            var resources = System.Windows.Application.Current.Resources;

            return (MessageType?)value switch
            {
                MessageType.Success => resources.Get("AlertSuccessAccent-SolidBrushColor"),
                MessageType.Error => resources.Get("AlertErrorAccent-SolidBrushColor"),
                MessageType.Warning => resources.Get("AlertWarningAccent-SolidBrushColor"),
                MessageType.Information => resources.Get("BrandBlue-SolidBrushColor-2"),
                _ => resources.Get("BlueAccent-SolidBrushColor")
            };
            */
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
