using static System.Console;

namespace Factory.AbstractFactory;

// Created as an internal, so instead to create a Tea, we will create an IHotDrink
internal class Tea : IHotDrink
{
    public void Consume()
    {
        WriteLine("This tea is nice but I´d prefer it with milk.");
    }
}