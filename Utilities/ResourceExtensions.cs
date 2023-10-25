using Avalonia.Controls;

namespace IsoniaCore.Utilities;

public static class ResourceExtensions
{
    public static T? GetResource<T>(this IResourceDictionary resourceDictionary, string key) where T : class
    {
        if (resourceDictionary.TryGetResource(key, null, out object? value))
            return value as T;
        return null;
    }
}
