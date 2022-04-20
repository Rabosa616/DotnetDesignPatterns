using System;

namespace Decorator.MultipleInheritanceWithInterfaces;

public class Lizard : ILizard
{
    public int Weight { get; set; }

    public void Crawl()
    {
        Console.WriteLine("Crawling in the dirt");
    }
}