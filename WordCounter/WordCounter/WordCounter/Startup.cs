using Microsoft.Extensions.DependencyInjection;
using WordCounter.Controller;
using WordCounter.Controller.CommandLineParser.Entities;
using WordCounter.Controller.CommandLineParser.Interfaces;
using WordCounter.Controller.Controller;
using WordCounter.Model;

namespace WordCounter;

public class Startup
{
    private readonly IServiceCollection _serviceCollection;
    public Startup(IServiceCollection serviceCollection)
    {
        _serviceCollection = serviceCollection;
    }

    public void Configure()
    {
        _serviceCollection.AddScoped<IFileCreator, FileCreator>();
        _serviceCollection.AddScoped<IWordCounterController, WordCounterController>();
        _serviceCollection.AddScoped<ICommandParserHandler, FileCounterHandler>();

    }

    public void Run()
    {
        var parser = _serviceCollection.BuildServiceProvider().GetRequiredService<ICommandParserHandler>();

        Console.WriteLine("""
                          -e - завершить работу программы
                          -ff {fileNameToRead} {fileNameToWrite} - выполнить
                          """);

        while (true)
        {
            var request = Console.ReadLine();
            if (request is null) continue;

            var parameters = request.Split(' ');
            if (parameters.Length > 0 && parameters[0] == "-e") break;

            parser.Parse(parameters);
        }
    }
}