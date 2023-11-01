using System.Text;

namespace IsoniaCore.DataGenerators;

public sealed class TextDataGenerator : DataGenerator
{
    private static readonly string[] loremIpsumWords = {
        "lorem", "ipsum", "dolor", "sit", "amet", "consectetur",
        "adipiscing", "elit", "sed", "do", "eiusmod", "tempor",
        "incididunt", "labore", "et", "magna", "aliqua", "enim",
        "ad", "minim", "veniam", "quis", "nostrud", "exercitation",
        "ullamco", "laboris", "nisi", "aliquip", "ex", "ea",
        "commodo", "consequat", "duis", "aute", "irure", "in",
        "reprehenderit", "voluptate", "velit", "esse", "cillum",
        "eu", "fugiat", "nulla", "pariatur", "excepteur",
        "sint", "occaecat", "cupidatat", "non", "proident", "sunt",
        "culpa", "qui", "officia", "deserunt", "mollit",
        "anim", "id", "est", "laborum"
    };
    private int nextLoremIpsumWordIndex = 0;

    public string RandomWord => loremIpsumWords[nextLoremIpsumWordIndex++ % loremIpsumWords.Length];

    public string RandomSentence(int minSentenceSize = 5, int maxSentenceSize = 15)
    {
        StringBuilder loremIpsumBuilder = new();

        int numWords = random.Next(minSentenceSize, maxSentenceSize);

        for (int i = 0; i < numWords; i++)
        {
            int randomIndex = random.Next(loremIpsumWords.Length);
            string word = loremIpsumWords[randomIndex];
            loremIpsumBuilder.Append(word).Append(' ');
        }

        return loremIpsumBuilder.ToString().Trim();
    }
}
