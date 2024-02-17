using System.Text.RegularExpressions;

namespace WordCounter.Model.WordCounter;

public class WordCounterFileStrategy : IWordCounter
{
    private readonly string _fileName;

    public WordCounterFileStrategy(string fileName)
    {
        _fileName = fileName;
    }

    public IDictionary<string, int> CountWords()
    {
        var dictionary = new Dictionary<string, int>();
        var sr = new StreamReader(_fileName);
        var sentence = sr.ReadLine();

        while (sentence is not null)
        {
            var words = Regex.Matches(sentence, @"\w+([-']\w+)?").ToList();
            foreach (var word in words)
            {
                if (dictionary.TryAdd(word.Value, 1)) continue;
                dictionary[word.Value] += 1;
            }

            sentence = sr.ReadLine();
        }

        sr.Close();

        return dictionary;
    }
}