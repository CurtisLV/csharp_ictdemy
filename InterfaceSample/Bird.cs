namespace InterfaceSample;

internal class Bird : Animal, IBird
{
    public void Chirp()
    {
        Console.WriteLine("♫ ♫ ♫");
    }

    public void Peck()
    {
        Console.WriteLine("Peck, peck!");
    }

    public override void Move()
    {
        Console.WriteLine("Flying...");
    }
}
