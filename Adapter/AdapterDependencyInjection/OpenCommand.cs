using System;

namespace Adapter.AdapterDependencyInjection;

public class OpenCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Opening a file");
    }
}