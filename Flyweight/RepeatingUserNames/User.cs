using System.Collections.Generic;
using System.Linq;

namespace Flyweight.RepeatingUserNames;

public class User
{
    private static readonly List<string> strings = new();
    private readonly int[] names;

    public User(string fullName)
    {
        static int getOrAdd(string s)
        {
            int idx = strings.IndexOf(s);
            if (idx != -1)
            {
                return idx;
            }
            else
            {
                strings.Add(s);
                return strings.Count - 1;
            }
        }

        names = fullName.Split(' ').Select(getOrAdd).ToArray();
    }

    public string FullName => string.Join(" ", names.Select(i => strings[i]));
}