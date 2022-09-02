using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary;

internal class DiaryC
{
    private Database database;

    public DiaryC()
    {
        database = new Database();
    }

    public DateTime ReadDateTime()
    {
        Console.WriteLine("Enter date and time as e.g. [01/13/2016 14:00]:");
        DateTime dateTime;

        while (!DateTime.TryParse(Console.ReadLine(), out dateTime))
        {
            Console.WriteLine("Error. Please try again: ");
        }
        return dateTime;
    }

    public void PrintEntries(DateTime day)
    {
        List<Entry> entries = database.FindEntries(day, false);
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void AddEntry()
    {
        DateTime dateTime = ReadDateTime();
        Console.WriteLine("Enter the entry text:");
        string text = Console.ReadLine(); 
        database.AddEntry(dateTime, text);
    }
}
