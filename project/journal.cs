using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in_entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(File))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine
            }
        }
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
               var parts = line.Split('|');
               if (parts.Length == 3)
               {
                var entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
               }
            }
        }
    }
    else
    {
        {
            Console.WriteLine("File does not exist.")
        }
    }
}