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

    public void SearchEntries()
    {
        // entering date
        DateTime dateTime = ReadDateTime();
        // searching for entries
        List<Entry> entries = database.FindEntries(dateTime, false);
        // printing entries
        if (entries.Count() > 0)
        {
            Console.WriteLine("Entries found:");
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("Nothing found");
        }

    }

    public void DeleteEntries()
    {
        Console.WriteLine("Entries with the same exact date and time will be deleted");
        DateTime dateTime = ReadDateTime();
        database.DeleteEntries(dateTime);
    }

    public void PrintHomeScreen()
    {
        Console.Clear();
        Console.WriteLine("Welcome to your virtual diary!");
        Console.WriteLine($"Today is: {DateTime.Now}");
        Console.WriteLine();

        Console.WriteLine("Today:\n------");
        PrintEntries(DateTime.Today);
        Console.WriteLine();
        Console.WriteLine("Tomorrow:\n------");
        PrintEntries(DateTime.Now.AddDays(1));
        Console.WriteLine();
    }
}
