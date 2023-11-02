using System.Text;

namespace IsoniaCore.DataGenerators;

public static class TextDataGenerator
{
    private static readonly Random random;
    static TextDataGenerator()
    {
        random = new();
    }

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
    private static int nextLoremIpsumWordIndex = 0;

    public static string RandomWord => loremIpsumWords[nextLoremIpsumWordIndex++ % loremIpsumWords.Length];

    public static string RandomWords(int minSentenceSize = 5, int maxSentenceSize = 15, char seperator = ' ')
    {
        StringBuilder loremIpsumBuilder = new();

        int numWords = random.Next(minSentenceSize, maxSentenceSize);

        for (int i = 0; i < numWords; i++)
        {
            int randomIndex = random.Next(loremIpsumWords.Length);
            string word = loremIpsumWords[randomIndex];
            loremIpsumBuilder.Append(word).Append(seperator);
        }

        return loremIpsumBuilder.ToString().Trim(seperator);
    }
}
