using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Iterator.ArrayBackedProperties;

public class Creature : IEnumerable<int>
{
    private readonly int[] stats = new int[3];
    private const int strength = 0;
    private const int agility = 1;
    private const int intelligence = 2;

    public int Strength { get => stats[strength]; set => stats[strength] = value; }
    public int Agility { get => stats[agility]; set => stats[agility] = value; }
    public int Intelligence { get => stats[intelligence]; set => stats[intelligence] = value; }

    // Instead of return (Strength + Agility + Intelligence) / 3.0;
    public double AverageStat => stats.Average();

    public IEnumerator<int> GetEnumerator()
    {
        return stats.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int this[int index]
    {
        get { return stats[index]; }
        set { stats[index] = value; }
    }
}