using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Singleton.SingletonImplementation;

public class SingletonDatabase : IDatabase
{
    private readonly Dictionary<string, int> capitals;

    // We make private the constructor
    private SingletonDatabase()
    {
        // Initializing database
        capitals = File.ReadAllLines("Capitals.txt")
            .Batch(2)
            .ToDictionary(list => list.ElementAt(0).Trim(), list => int.Parse(list.ElementAt(1)));
    }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }

    // This is the way we initialize and consume the singleton instance
    // We use Lazy in order to call the constructor only when the object is created
    private static readonly Lazy<SingletonDatabase> instance = new(() => new SingletonDatabase());

    public static SingletonDatabase Instance => instance.Value;
}