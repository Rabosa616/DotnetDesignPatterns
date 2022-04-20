using System;

namespace Adapter.AdapterDependencyInjection;

public class SaveCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Saving a file");
    }
}