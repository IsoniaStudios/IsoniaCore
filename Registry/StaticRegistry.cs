namespace IsoniaCore.Registry;

public static class Registry
{
    public static readonly IRegistry Instance;
    static Registry()
    {
#if WINDOWS
        Instance = new WindowsRegistry();
#elif MACOS
        Instance = new MacOSRegistry();
#elif LINUX
        Instance = new LinuxRegistry();
#else
        throw new NotSupportedException("Platform not supported");
#endif
    }
}
