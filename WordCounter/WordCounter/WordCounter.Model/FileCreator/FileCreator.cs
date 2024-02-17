namespace WordCounter.Model;

public class FileCreator : IFileCreator
{
    public void Create(string fileName, IDictionary<string, int> dictionary)
    {
        var sw = new StreamWriter(fileName);
        foreach (var el in dictionary)
        {
            sw.WriteLine($"{el.Key} {el.Value}");
        }
        sw.Close();
    }
}