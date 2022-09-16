using Delegates;

//static int Square(int a)
//{
//    return a * a;
//}

Number numbers = new Number();
Console.WriteLine(numbers);

////numbers.PerformOperation(Square);
////Console.WriteLine(numbers);

//static int Double(int a)
//{
//    return a * 2;
//}

//numbers.PerformOperation(Double);

//Console.WriteLine(numbers);

numbers.PerformOperation(delegate (int a)
{
    return a * a;
});

Console.WriteLine(numbers);

numbers.PerformOperation(delegate (int a)
{
    return a * 2;
});
Console.WriteLine(numbers);
