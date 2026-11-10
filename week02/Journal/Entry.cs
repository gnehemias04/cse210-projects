using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
}

//Date: November 9, 2026
//Prompt: What was the best part of your day?
//I spent some time learning C#.