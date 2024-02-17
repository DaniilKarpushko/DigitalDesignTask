namespace WordCounter.Model;

public interface IFileCreator
{
    void Create(string fileName, IDictionary<string, int> dictionary);
}