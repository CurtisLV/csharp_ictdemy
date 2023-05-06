namespace Delegates;

internal class Number
{
    private List<int> numbers = new List<int>();

    public Number()
    {
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i + 1);
        }
    }

    public override string ToString()
    {
        string output = "";
        foreach (int number in numbers)
        {
            output += number + ", ";
        }
        return output;
    }

    //public delegate int Operation(int a);

    public void PerformOperation(Func<int, int> operation)
    {
        for (var i = 0; i < 10; i++)
        {
            numbers[i] = operation(numbers[i]);
        }
    }
}
