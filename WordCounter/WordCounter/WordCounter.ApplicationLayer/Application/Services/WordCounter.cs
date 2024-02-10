using System.Net;
using WordCounter.ApplicationLayer.Application.Interfaces;

namespace WordCounter.ApplicationLayer.Application.Services;

public class WordCounter: IWordCounter
{
    
    public void Count(string fileName)
    {
        foreach (var line in File.ReadLines(fileName))
        {
            
        }
    }
}