using BirthDateCalc;

Console.Write("Enter your birth date: ");
string dateText = Console.ReadLine();
DateTime birthday = DateTime.Parse(dateText);
Person user = new Person(birthday);

Console.WriteLine(
    $"You're {user.GetAge()} years old and your birthday is comming up in {user.GetDaysToBirthday()} days."
);
