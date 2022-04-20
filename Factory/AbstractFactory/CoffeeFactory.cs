using static System.Console;

namespace Factory.AbstractFactory;

internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream and suggar, enjoy!");
        return new Coffee();
    }
}