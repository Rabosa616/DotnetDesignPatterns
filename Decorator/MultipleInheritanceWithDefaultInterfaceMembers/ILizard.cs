using System;

namespace Decorator.MultipleInheritanceWithDefaultInterfaceMembers;

public interface ILizard : ICreature
{
    void Crawl()
    {
        // Default definition of the interface method
        if (Age < 10)
        {
            Console.WriteLine("I am crawling");
        }
    }
}