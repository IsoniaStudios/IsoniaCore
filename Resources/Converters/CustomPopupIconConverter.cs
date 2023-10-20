using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class CustomPopupIconConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        /*
        var resources = System.Windows.Application.Current.Resources;

        return (PopupIcon?)value switch
        {
            PopupIcon.None => resources.Get("NoIcon"),
            PopupIcon.Error => resources.Get("ErrorIcon"),
            PopupIcon.Warning => resources.Get("WarningIcon"),
            PopupIcon.Information => resources.Get("InformationIcon"),
            PopupIcon.Question => resources.Get("QuestionIcon"),
            _ => resources["NoIcon"]
        };

        */
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
