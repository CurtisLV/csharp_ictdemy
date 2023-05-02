using Calculator;

Console.WriteLine("Enter 1st number: ");
double num1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
double num2 = Double.Parse(Console.ReadLine());

CalculatorLogic calc = new CalculatorLogic(num1, num2);

Console.WriteLine($"Sum: {calc.Sum()}");
Console.WriteLine($"Difference: {calc.Difference()}");
Console.WriteLine($"Product: {calc.Product()}");
Console.WriteLine($"Quotien: {calc.Quotien()}");
