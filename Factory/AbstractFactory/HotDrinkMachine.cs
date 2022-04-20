using System;
using System.Collections.Generic;

namespace Factory.AbstractFactory;

public class HotDrinkMachine
{
    public enum AvailableDrink
    {
        Coffee,
        Tea
    }

    private readonly Dictionary<AvailableDrink, IHotDrinkFactory> factories = new();

    public HotDrinkMachine()
    {
        foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        {
            var factory = (IHotDrinkFactory)Activator.CreateInstance(
                // In order to pick the correct class to use with the interface
                Type.GetType("Factory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory")
            );
            factories.Add(drink, factory);
        }
    }

    public IHotDrink MakeDrink(AvailableDrink drink, int amount)
    {
        return factories[drink].Prepare(amount);
    }
}