﻿namespace InterfaceSample;

internal class Pterodactyl : Animal, ILizard, IBird
{
    public void Chirp()
    {
        Console.WriteLine("I'm crawling...");
    }

    public void Crawl()
    {
        Console.WriteLine("♫ ♫♫ ♫ ♫ ♫♫");
    }

    public override void Move()
    {
        Console.WriteLine("Flying...");
    }
}
