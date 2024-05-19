using System;
using System.Linq;
using System.Collections.Generic;



public class Entry
{
    public DateTime _date = DateTime.Now;
    public string _promptText;
    public string _entryText;




    public void Display(string _promptText)
    {

        Console.WriteLine(_date + _promptText + _entryText);

    }
}