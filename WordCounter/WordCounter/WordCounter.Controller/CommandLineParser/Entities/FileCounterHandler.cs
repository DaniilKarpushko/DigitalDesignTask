namespace WordCounter.Controller.CommandLineParser.Entities;

public class FileCounterHandler : CommandParserBase
{
    public FileCounterHandler(IWordCounterController controller) : base(controller)
    {
    }
    public override void Parse(string[] args)
    {
        if (args[0] == "-ff" && !string.IsNullOrEmpty(args[1])
                && !string.IsNullOrEmpty(args[2]))
        {
            _controller.CountWordsFromFile(args[1], args[2]);
        }
        else
        {
            _next?.Parse(args);
        }
    }
}