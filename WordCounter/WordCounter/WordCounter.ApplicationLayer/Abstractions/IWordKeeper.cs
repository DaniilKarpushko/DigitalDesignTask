namespace WordCounter.ApplicationLayer.Abstractions;

public interface IWordKeeper
{
    void SaveWord(string word);

    IDictionary<string, int> GetWordList();
}