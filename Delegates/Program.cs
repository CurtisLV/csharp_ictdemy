using Delegates;

static int Square(int a)
{
    return a * a;
}

Number numbers = new Number();

Console.WriteLine(numbers);


numbers.PerformOperation(Square);

Console.WriteLine(numbers);
