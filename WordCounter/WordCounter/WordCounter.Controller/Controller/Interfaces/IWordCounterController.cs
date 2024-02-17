namespace WordCounter.Controller;

public interface IWordCounterController
{
    void CountWordsFromFile(string fileToRead, string fileToCreate);
}