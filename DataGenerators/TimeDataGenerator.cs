namespace IsoniaCore.DataGenerators;

public static class TimeDataGenerator
{
    private static readonly Random random;
    static TimeDataGenerator()
    {
        random = new();
    }

    public static TimeSpan GenerateRandomTimeSpan()
    {
        int hours = random.Next(24);
        int minutes = random.Next(60);
        int seconds = random.Next(60);
        return new TimeSpan(hours, minutes, seconds);
    }

    public static DateTime GenerateRandomDateTime()
    {
        DateTime start = new(1995, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(random.Next(range))
                    .AddHours(random.Next(24))
                    .AddMinutes(random.Next(60))
                    .AddSeconds(random.Next(60));
    }

    public static DateTime GenerateRandomDate()
    {
        DateTime start = new(1995, 1, 1);
        int range = (DateTime.Today - start).Days;
        return start.AddDays(random.Next(range));
    }
}
