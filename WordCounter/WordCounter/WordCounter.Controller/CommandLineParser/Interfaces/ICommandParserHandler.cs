namespace WordCounter.Controller.CommandLineParser.Interfaces;

public interface ICommandParserHandler
{
    void Parse(string[] args);

    void SetNext(ICommandParserHandler next);
}