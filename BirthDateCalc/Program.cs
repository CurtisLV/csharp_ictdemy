Console.WriteLine("Enter your birth date: ");
DateTime birthdate = DateTime.Parse(Console.ReadLine());
DateTime today = DateTime.Today;

int age = today.Year - birthdate.Year;
if (birthdate.Date > today.AddYears(age))
{
    age--;
}

Console.WriteLine($"You're {age} years old and your birthday is coming up in {} days.");
