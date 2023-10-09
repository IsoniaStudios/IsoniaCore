using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Converters
{
    public class MessageTypeToSecondaryForegroundConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            /*
            var resources = System.Windows.Application.Current.Resources;

            return (MessageType?)value switch
            {
                MessageType.Success => resources.Get("OrnamentalBorder-SolidBrushColor"),
                MessageType.Error => resources.Get("OrnamentalBorder-SolidBrushColor"),
                MessageType.Warning => resources.Get("BrandGray-SolidBrushColor-0"),
                MessageType.Information => resources.Get("OrnamentalBorder-SolidBrushColor"),
                _ => resources.Get("OrnamentalBorder-SolidBrushColor")
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
