using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string> {
        "What goals did I not accomplish today?",
        "What workout did I do today?",
        "Was there anything positive I learned from someone today?",
        "What was the best part of my day?",
        "What church hymn did appeal to me this morning?",
        "How do I find today's study time?"
    };

    //add new entry with a random prompt
    public void AddEntry()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(DateTime.Now, prompt, response);
        _entries.Add(entry);
        Console.WriteLine("Added Entry!\n");
    }

    //Display All Entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine($"No entries found. \n");
        }
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine();
    }
    //to save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                //save entry in "|" separated style
                outputFile.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
        Console.WriteLine("Saved Journal!\n");
    }
    //Load journal from file
    public void LoadfromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    //parse date from parts[0]
                    if (DateTime.TryParse(parts[0], out DateTime entryDate))
                        {
                            Entry entry = new Entry(entryDate, parts[1], parts[2]);
                            _entries.Add(entry);
                        }
                    else
                    {
                        Console.WriteLine($"Invalid date format: {parts[0]}");
                    }
                }
            }
             Console.WriteLine("Loaded Journal!\n");
        }
        else
        {
            Console.WriteLine("File not found!\n");
        }
    }
}