using MoreLinq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Singleton.SingletonDependencyInjection;

// Is not a singleton but is treated as a singleton by the application
public class OrdinaryDatabase : IDatabase
{
    private readonly Dictionary<string, int> capitals;

    public OrdinaryDatabase()
    {
        // Initializing database
        capitals = File.ReadAllLines(Path.Combine(new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "Capitals.txt"))
            .Batch(2)
            .ToDictionary(list => list.ElementAt(0).Trim(), list => int.Parse(list.ElementAt(1)));
    }

    public int GetPopulation(string name)
    {
        return capitals[name];
    }
}