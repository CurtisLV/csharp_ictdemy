using System.ComponentModel;

Console.WriteLine("Printing the sum of all the numbers in the dates for the following 7 days");

// Create a date
DateTime date = DateTime.Now;

// do 7 times
for (int i = 0; i < 7; i++)
{
    // sum day/month/year
    int sum = date.Day + date.Month + date.Year;
    // write to console "dd/mm/yyyy - sum"

    Console.WriteLine($"{date.ToShortDateString()} - {sum}");

    // date add 1 day 
    date = date.AddDays(1);
}


