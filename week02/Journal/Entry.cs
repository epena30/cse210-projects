using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    public override string ToString()
    {
        return $"Date: {_date}\nPrompt: {_promptText}\nResponse: {_entryText}\n";
    }
    public string SaveToFile()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
    public static Entry FromFileString(string line)
    {
        string[]
        parts = line.Split("|");
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        return null;

        }
    }
