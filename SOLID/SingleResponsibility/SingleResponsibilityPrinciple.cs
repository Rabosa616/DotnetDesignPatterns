using System;
using System.Collections.Generic;
using System.IO;

namespace SOLID.SingleResponsibility;

public class Journal
{
    private readonly List<string> entries = new();

    private static int count = 0;

    public int AddEntry(string text)
    {
        entries.Add($"{++count} : {text}");
        return count; // memento pattern
    }

    public void RemoveEntry(int index)
    {
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }

    // People usually if they want to persist data, they add the Save
    public void Save(string fileName)
    {
        File.WriteAllText(fileName, ToString());
    }

    // This kind of responsibility is not for this class
    public static Journal Load(string fileName)
    {
        // return ....
        throw new NotImplementedException();
    }
}

// Create a new class instead add all responsibility on Journal class
public class Persistence
{
    public static void SaveToFile(Journal j, string fileName, bool overWrite = false)
    {
        if (overWrite || !File.Exists(fileName))
        {
            File.WriteAllText(fileName, j.ToString());
        }
    }
}