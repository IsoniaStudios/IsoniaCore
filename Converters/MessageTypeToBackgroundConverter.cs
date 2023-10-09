using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Converters
{
    public class MessageTypeToBackgroundConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            /*
            var resources = System.Windows.Application.Current.Resources;

            return (MessageType?)value switch
            {
                MessageType.Success => resources.Get("AlertSuccess-SolidBrushColor"),
                MessageType.Error => resources.Get("AlertError-SolidBrushColor"),
                MessageType.Warning => resources.Get("AlertWarning-SolidBrushColor"),
                MessageType.Information => resources.Get("BlueAccent-SolidBrushColor"),
                _ => resources.Get("BluePrimary-SolidBrushColor")
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
