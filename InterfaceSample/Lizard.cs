namespace InterfaceSample;

internal class Lizard : Animal, ILizard
{
    public void Crawl()
    {
        Console.WriteLine("Crawling...");
    }

    public override void Move()
    {
        Console.WriteLine("Crawling...");
    }
}
