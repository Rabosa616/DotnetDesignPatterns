using System.Collections.Generic;

namespace Singleton.SingletonImplementation;

public class SingletonRecordFinder
{
    public static int GetTotalPopulation(IEnumerable<string> names)
    {
        var result = 0;
        foreach (var name in names)
        {
            // Hardcoded reference
            result += SingletonDatabase.Instance.GetPopulation(name);
        }

        return result;
    }
}