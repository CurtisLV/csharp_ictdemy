namespace RollDice2;

internal class RollingDice
{
    private static Random random = new Random();

    public int Throw()
    {
        return random.Next(6) + 1;
    }
}
