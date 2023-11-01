namespace IsoniaCore.DataGenerators;

public abstract class DataGenerator
{
    protected readonly Random random;

    protected DataGenerator(Random random)
    {
        this.random = random;
    }

    protected DataGenerator()
    {
        random = new();
    }
}
