using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;




public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;
    public string _file;

    public void AddEntry(Entry newEntry)
    {

        _entries.Add(newEntry);
        Console.WriteLine("new entry added");


    }

    public void DisplayAll()
    {
        Console.WriteLine("aca estoy en displayAll");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"-Date: {entry._date}; \n -Prompt: {entry._promptText}; \n -Me: {entry._entryText}");
        }
    }


    public void saveEntriesToFile()
    {
        Console.Write("Write the name of the file to save the entries");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry write in _entries)
            {
                outputFile.WriteLine($"-Date: {write._date}; \n -Prompt: {write._promptText}; \n -Me: {write._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {

        Console.Write("Write the name of the file you want to read");
        _file = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }


}