using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDateCalc;

internal class Person
{
    public DateTime BirthDate
    {
        get; set;
    }

    public Person(DateTime birthDate)
    {
        BirthDate = birthDate;
    }

    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDate.Year;
        if (today < BirthDate.AddYears(age))
        {
            age--;
        }
        return age;
    }

    public int GetDaysToBirthday()
    {
        DateTime today = DateTime.Today;
        DateTime next = BirthDate.AddYears(GetAge());

        if (next < today)
        {
            next = next.AddYears(1);
        }

        int numDays = (next - today).Days;

        return numDays;
    }
}
