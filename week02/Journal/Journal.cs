using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string file)
    {

        Console.WriteLine("Journal saved successfully.");
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.SaveToFile());
                }
            }
        }
    }

    public void LoadFromFile(string file)
{
    using (StreamWriter outputFile = new StreamWriter (file))
    {
        Console.WriteLine("Journal loaded successfully.");
      
    //}
    //_entries.Clear();
    //string[] lines = File.ReadAllLines(file);
    //foreach (string line in lines)
    //{
       // Entry entry = Entry.FromFileString(line);
       // if (entry != null)
       // {
       //     _entries.Add(entry);
      //  }
    }
  
    }

}


