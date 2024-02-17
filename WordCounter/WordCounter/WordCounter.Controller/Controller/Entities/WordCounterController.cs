using WordCounter.Model;
using WordCounter.Model.WordCounter;

namespace WordCounter.Controller.Controller;

public class WordCounterController : IWordCounterController
{
    private readonly IFileCreator _fileCreator;

    public WordCounterController(IFileCreator fileCreator)
    {
        _fileCreator = fileCreator;
    }

    public void CountWordsFromFile(string fileToRead, string fileToCreate)
    {
        var wordCounter = new WordCounterFileStrategy(fileToRead);
        var dict = wordCounter.CountWords();
        _fileCreator.Create(fileToCreate, dict);
    }
}