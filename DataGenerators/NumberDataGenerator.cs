namespace IsoniaCore.DataGenerators;

public static class NumberDataGenerator
{
    private static readonly Random random;
    static NumberDataGenerator()
    {
        random = new();
    }

    public static double RandomDouble(double minValue = 0, double maxValue = 10)
    {
        return random.NextDouble() * (maxValue - minValue) + minValue;
    }
    public static double[] RandomDoubles(int length = 100, double minValue = 0, double maxValue = 10)
    {
        double[] arr = new double[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = RandomDouble(minValue, maxValue);
        }

        return arr;
    }
    public static int RandomInt(int minValue = 0, int maxValue = 10)
    {
        return random.Next(minValue, maxValue);
    }
    public static int[] RandomInts(int length = 100, int minValue = 0, int maxValue = 10)
    {
        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = RandomInt(minValue, maxValue);
        }

        return arr;
    }
}
