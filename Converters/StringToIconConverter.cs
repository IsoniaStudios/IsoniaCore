using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Converters
{
    public class StringToIconConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            /*
            var resources = System.Windows.Application.Current.Resources;
            if (value is string key && resources.TryGet(key, out object? resource))
                return resource;
            return resources["NoIcon"];
            */
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
