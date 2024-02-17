using WordCounter.Controller.CommandLineParser.Interfaces;

namespace WordCounter.Controller.CommandLineParser.Entities;

public abstract class CommandParserBase : ICommandParserHandler
{
    protected ICommandParserHandler? _next;
    protected readonly IWordCounterController _controller;

    protected CommandParserBase(IWordCounterController controller)
    {
        _controller = controller;
    }

    public abstract void Parse(string[] args);
    public void SetNext(ICommandParserHandler next)
    {
        if (_next is not null)
        {
            _next.SetNext(next);
        }
        else
        {
            _next = next;
        }
    }
}