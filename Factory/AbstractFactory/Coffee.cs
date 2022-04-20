using static System.Console;

namespace Factory.AbstractFactory;

// Created as an internal, so instead to create a Coffee, we will create an IHotDrink
internal class Coffee : IHotDrink
{
    public void Consume()
    {
        WriteLine("This coffee is sensational!");
    }
}