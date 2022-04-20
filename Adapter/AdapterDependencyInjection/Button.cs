using System;

namespace Adapter.AdapterDependencyInjection;

public class Button
{
    private readonly ICommand command;
    private readonly string name;

    public Button(ICommand command, string name)
    {
        this.command = command;
        this.name = name;
    }

    public void Click()
    {
        command.Execute();
    }

    public void PrintMe()
    {
        Console.WriteLine($"I am a button called {name}");
    }
}