namespace TheLottery;

internal class Lottery
{
    private List<int> numbers;
    private Random random;

    public Lottery()
    {
        random = new Random();
        numbers = new List<int>();
    }

    public int Lot()
    {
        int number = random.Next(100) + 1;
        numbers.Add(number);
        return number;
    }

    public string Print()
    {
        string s = "";
        numbers.Sort();
        foreach (int i in numbers)
        {
            s += i + " ";
        }
        return s;
    }
}
