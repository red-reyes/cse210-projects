using System;

public class Entry
{
    private DateTime _date;
    private string _promptText;
    private string _entryText;

    //parameter and field assignments
    public Entry(DateTime date, string promptText, string entryText)
    {
        _date = date; //for current date
        _promptText = promptText;
        _entryText = entryText;
    }

    //public properties to access private fields
    public DateTime Date => _date;
    public string PromptText => _promptText;
    public string EntryText => _entryText;
    
    //method to displpay entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
