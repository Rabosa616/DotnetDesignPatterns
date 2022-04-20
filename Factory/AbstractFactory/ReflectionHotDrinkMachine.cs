using System;
using System.Collections.Generic;
using static System.Console;

namespace Factory.AbstractFactory;

public class ReflectionHotDrinkMachine
{
    private readonly List<Tuple<string, IHotDrinkFactory>> factories = new();

    public ReflectionHotDrinkMachine()
    {
        foreach (var item in typeof(ReflectionHotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(item) && !item.IsInterface)
            {
                factories.Add(Tuple.Create(
                    item.Name.Replace("Factory", string.Empty),
                    (IHotDrinkFactory)Activator.CreateInstance(item)
                    ));
            }
        }
    }

    public IHotDrink MakeDrink(int amount)
    {
        WriteLine("Available drinks:");
        for (int index = 0; index < factories.Count; index++)
        {
            var tuple = factories[index];
            WriteLine($"{index}: {tuple.Item1}");
        }

        while (true)
        {
            string s;
            if ((s = Console.ReadLine()) != null && int.TryParse(s, out int i) && i >= 0 && i < factories.Count)
            {
                return factories[i].Item2.Prepare(amount);
            }
        }
    }
}