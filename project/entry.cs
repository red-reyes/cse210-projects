using System;

public class Entry;
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promtText, string entryText)
    {
        _date = date;
        _promptText = prompText;
        entryText = entryText;
    }

    public string Date => _date;
    public string PromptText => _promptText;
    publics string EntryText => _entryText;
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompText}");
        COnsole.WriteLine($"Entry: {_entryText}");
    }
}
