using Avalonia;

namespace IsoniaCore.DataGenerators;

public sealed class NumberDataGenerator : DataGenerator
{
    #region Random
    public double RandomValue(double minValue = 0, double maxValue = 10)
    {
        return random.NextDouble() * (maxValue - minValue) + minValue;
    }
    public double[] RandomValues(int length = 100, double minValue = 0, double maxValue = 10)
    {
        double[] arr = new double[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = RandomValue(minValue, maxValue);
        }

        return arr;
    }
    public Point[] RandomPoints(int length = 100, double minValue = 0, double maxValue = 10)
    {
        Point[] arr = new Point[length];
        double[] x = RandomValues(length, minValue, maxValue);
        double[] y = RandomValues(length, minValue, maxValue);

        for (int i = 0; i < length; i++)
        {
            arr[i] = new Point(x[i], y[i]);
        }

        return arr;
    }
    public (double X, double y)[] RandomTuples(int length = 100, double minValue = 0, double maxValue = 10)
    {
        (double X, double y)[] arr = new (double X, double y)[length];
        double[] x = RandomValues(length, minValue, maxValue);
        double[] y = RandomValues(length, minValue, maxValue);

        for (int i = 0; i < length; i++)
        {
            arr[i] = (x[i], y[i]);
        }

        return arr;
    }

    #region Sine
    public double[] RandomSineWave(int numSamples, double amplitude, double frequency, double phase)
    {
        double[] arr = new double[numSamples];

        double randomAmplitude = random.NextDouble() * amplitude;
        double randomFrequency = random.NextDouble() * frequency;
        double randomPhase = random.NextDouble() * phase;

        for (int i = 0; i < numSamples; i++)
        {
            double x = (double)i / numSamples;
            double y = randomAmplitude * Math.Sin(2 * Math.PI * randomFrequency * x + randomPhase);
            arr[i] += y;
        }

        return arr;
    }
    #endregion
    #endregion
}
