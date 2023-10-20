using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class VersionConverter: IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if(value is Version v)
        {
            if (parameter is string p && int.TryParse(p, out int fieldCount))
                return v.ToString(fieldCount);
            return v.ToString();
        }
        return AvaloniaProperty.UnsetValue;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}