using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<string> _entries = new List<string>();

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public List<string> GetEntries()
    {
        return _entries;
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine("------------------------\n");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries = File.ReadAllLines(filename).ToList();
            Console.WriteLine($"Journal loaded from '{filename}'.");
        }
        else
        {
            Console.WriteLine($"File '{filename}' not found.");
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, _entries);
        Console.WriteLine($"Journal saved to '{filename}'.");
    }
}
