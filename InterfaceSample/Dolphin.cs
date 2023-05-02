namespace InterfaceSample;

internal class Dolphin : Animal
{
    public void Jump()
    {
        Console.WriteLine("Dolphin flip!");
    }

    public override void Move()
    {
        Console.WriteLine("Swimming...");
    }
}
