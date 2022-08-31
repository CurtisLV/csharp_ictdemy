
DateTime dateTime = new DateTime();
Console.WriteLine(dateTime);

// output: 01 / 01 / 0001 00:00:00  


DateTime dateTime1 = new DateTime(2016, 7, 5);
Console.WriteLine(dateTime1);
// output: 05/07/2016 00:00:00


// Now (Can use Today with time then 00:00:00)
DateTime dateTime2 = DateTime.Now;
Console.WriteLine(dateTime2);
// output: 30/08/2022 21:06:39
Console.WriteLine($"It is month number {dateTime2.Month} of the year {dateTime2.Year}.");

Console.WriteLine($"{dateTime2.DayOfWeek}, {dateTime2.DayOfYear}");


// Adding days /and other time units
Console.WriteLine(dateTime2.AddDays(50));
