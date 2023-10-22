﻿using Avalonia.Data.Converters;
using System.Globalization;

namespace IsoniaCore.Resources.Converters;

public class TextToUpperConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string text)
            return text.ToUpper();
        return value;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
