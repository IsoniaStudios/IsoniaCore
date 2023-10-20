using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class CenterToolTipConverter : IMultiValueConverter
{
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values == null || values.Count < 2)
            throw new ArgumentException($"The {nameof(values)} parameter must contain at least two values.", nameof(values));

        if (values[0] is not double placementTargetWidth || values[1] is not double toolTipWidth)
            throw new InvalidCastException("The values must be of type double.");

        return toolTipWidth / 2.0 - placementTargetWidth / 2.0;
    }
}
