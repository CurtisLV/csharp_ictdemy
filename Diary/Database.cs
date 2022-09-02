using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary;

internal class Database
{
    private List<Entry> entries;

    public Database()
    {
        entries = new List<Entry>();
    }

    // Methods

    public void AddEntry(DateTime Occur, string text)
    {
        entries.Add(new Entry(Occur, text));
    }

    public List<Entry> FindEntries(DateTime date, bool byTime)
    {
        List<Entry> found = new List<Entry>();
        foreach (Entry entry in entries)
        {   // Filtered by time and date
            if (((byTime) && (entry.Occurs == date)) 
            || 
            ((!byTime) && (entry.Occurs.Date == date.Date))) 
            {
                found.Add(entry);
            }
        }
        return found;
    }

    public void DeleteEntries(DateTime date)
    {
        List<Entry> found = FindEntries(date, true);
        foreach (Entry entry in found)
        {
            entries.Remove(entry);
        }
    }
}
