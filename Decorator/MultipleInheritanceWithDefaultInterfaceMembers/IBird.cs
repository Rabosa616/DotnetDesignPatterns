using System;

namespace Decorator.MultipleInheritanceWithDefaultInterfaceMembers;

public interface IBird : ICreature
{
    void Fly()
    {
        // Default definition of the interface method
        if (Age >= 10)
        {
            Console.WriteLine("I am flying");
        }
    }
}