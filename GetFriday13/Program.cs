

using System;

Console.WriteLine("Prints all Fridays 13th for entered interval:");
Console.WriteLine("Enter the first date: ");
DateTime date1 = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter the second date: ");
DateTime date2 = DateTime.Parse(Console.ReadLine());

Console.Write("Fridays 13th: ");

// try to find friday 
while (date1.DayOfWeek != DayOfWeek.Friday)
{
    date1 = date1.AddDays(1);
}

// when friday, add 7 days, check if 13th print all dates while date2 is smaller

while (date1 < date2)
{
    if (date1.Day == 13)
    {
        Console.Write(date1.ToShortDateString() + ", ");
    }
  
    date1 = date1.AddDays(7);
}