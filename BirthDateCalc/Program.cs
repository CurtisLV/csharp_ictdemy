using BirthDateCalc;

Console.WriteLine("Enter your birth date: ");

Person user = new Person(DateTime.Parse(Console.ReadLine()));

Console.WriteLine($"You're {user.GetAge()} years old and your birthday is coming up in {user.GetDaysToBirthday()} days.");
