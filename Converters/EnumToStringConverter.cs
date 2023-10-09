using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Converters
{
    public class EnumToStringConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                throw new ArgumentException($"The {nameof(value)} parameter must not be empty.", nameof(value));

            return Enum.GetName(value.GetType(), value);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
