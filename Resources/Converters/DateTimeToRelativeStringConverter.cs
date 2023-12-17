using System.Globalization;

namespace IsoniaCore.Resources.Converters;

public sealed class DateTimeToRelativeStringConverter : TimeToStringConverter
{
    public override object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not DateTime dateTime)
            return "Invalid Date";

        return base.Convert(dateTime, targetType, parameter, culture);
    }
}