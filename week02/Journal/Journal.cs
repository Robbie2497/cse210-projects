using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Cancelled: no file name enterd.");
            return;
        }

        if (string.IsNullOrWhiteSpace(Path.GetExtension(filename)))
        {
            filename += ".txt";
        }

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._response}~~{entry._scripture}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Cancelled: no file name enterd.");
            return;
        }
        if (string.IsNullOrWhiteSpace(Path.GetExtension(filename)))
        {
            filename += ".txt";
        }
        string[] lines = File.ReadAllLines(filename);
        try
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");
                Entry newEntries = new Entry();
                newEntries._date = parts[0];
                newEntries._prompt = parts[1];
                newEntries._response = parts[2];
                newEntries._scripture = parts[3];
                _entries.Add(newEntries);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error {e.Message}");
        }
    }
}