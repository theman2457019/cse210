using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        //System.Console.WriteLine("Entry added to journal.");
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Load()
    {
        try
        {
            System.Console.WriteLine("Enter the file path to load the journal:");
            string filePath = Console.ReadLine();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    Entry entry = new Entry();
                    entry._date = sr.ReadLine();
                    entry._prompt = sr.ReadLine();
                    entry._text = sr.ReadLine();
                    _entries.Add(entry);
                }
            }
            System.Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
    }

    public void Save()
    {
        System.Console.WriteLine("Enter the file path to save the journal:");
        string filePath = Console.ReadLine();
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Entry entry in _entries)
                {
                    sw.WriteLine(entry._date);
                    sw.WriteLine(entry._prompt);
                    sw.WriteLine(entry._text);
                }
            }
            System.Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }

    }
    public void Delete()
    {
        _entries.Clear();
        System.Console.WriteLine("Entries deleted.");
    }
}