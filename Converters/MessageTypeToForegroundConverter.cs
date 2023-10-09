using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Converters
{
    public class MessageTypeToForegroundConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            /*
            var resources = System.Windows.Application.Current.Resources;

            return (MessageType?)value switch
            {
                MessageType.Success => resources.Get("BrandWhite-SolidBrushColor"),
                MessageType.Error => resources.Get("BrandWhite-SolidBrushColor"),
                MessageType.Warning => resources.Get("BrandBlack-SolidBrushColor-0"),
                MessageType.Information => resources.Get("BrandWhite-SolidBrushColor"),
                _ => resources.Get("BrandWhite-SolidBrushColor")
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
