Console.WriteLine("Enter your birth date: ");
DateTime birthdate = DateTime.Parse(Console.ReadLine());
DateTime today = DateTime.Today;

int age = today.Year - birthdate.Year;
if (birthdate.Date > today.AddYears(age))
{
    age--;
}

DateTime next = birthdate.AddYears(age);

if (next < today)
{
    next = next.AddYears(1);
}

int numDays = (next - today).Days;

Console.WriteLine($"You're {age} years old and your birthday is coming up in {numDays} days.");
