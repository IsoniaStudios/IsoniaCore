using System.Globalization;
using Avalonia.Data.Converters;

namespace IsoniaCore.Resources.Converters;

public class TimeToStringConverter : IValueConverter
{
    public virtual object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not TimeSpan timeSince)
            return "Invalid Time";

        if (timeSince.TotalSeconds < 60)
        {
            return "Just now";
        }
        if (timeSince.TotalMinutes < 60.0)
        {
            return timeSince.Minutes > 1 ? $"{timeSince.Minutes} minutes ago" : "1 minute ago";
        }
        if (timeSince.TotalHours < 24.0)
        {
            return timeSince.Hours > 1 ? $"{timeSince.Hours} hours ago" : "1 hour ago";
        }
        if (timeSince.TotalDays < 30.0)
        {
            return timeSince.Days > 1 ? $"{timeSince.Days} days ago" : "1 day ago";
        }
        if (timeSince.TotalDays < 365.0)
        {
            int months = (int)(timeSince.TotalDays / 30.0);
            return months > 1 ? $"{months} months ago" : "1 month ago";
        }
        int years = (int)(timeSince.TotalDays / 365.0);
        return years > 1 ? $"{years} years ago" : "1 year ago";
    }

    public virtual object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}