namespace WordCounter.Model.WordCounter;

public interface IWordCounter
{
    IDictionary<string, int> CountWords();
}