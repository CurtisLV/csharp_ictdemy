using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena;

internal class Arena
{
    private Warrior warrior1;
    private Warrior warrior2;
    private RollingDie die;

    public Arena(Warrior warrior1, Warrior warrior2, RollingDie die)
    {
        this.warrior1 = warrior1;
        this.warrior2 = warrior2;
        this.die = die;
    }

    private void Render()
    {
        string ascii =
            "\r\n      __        _______     _______   _____  ___         __      \r\n     /\"\"\\      /\"      \\   /\"     \"| (\\\"   \\|\"  \\       /\"\"\\     \r\n    /    \\    |:        | (: ______) |.\\\\   \\    |     /    \\    \r\n   /' /\\  \\   |_____/   )  \\/    |   |: \\.   \\\\  |    /' /\\  \\   \r\n  //  __'  \\   //      /   // ___)_  |.  \\    \\. |   //  __'  \\  \r\n /   /  \\\\  \\ |:  __   \\  (:      \"| |    \\    \\ |  /   /  \\\\  \\ \r\n(___/    \\___)|__|  \\___)  \\_______)  \\___|\\____\\) (___/    \\___)\r\n                                                                 \r\n";

        Console.Clear();
        Console.WriteLine($"{ascii} \n");
        Console.WriteLine("Warriors health: \n");

        PrintWarrior(warrior1);
        Console.WriteLine();
        PrintWarrior(warrior2);
        Console.WriteLine();
    }

    private void PrintMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(500);
    }

    public void Fight()
    {
        Warrior w1 = warrior1;
        Warrior w2 = warrior2;

        Console.WriteLine("Welcome to the Arena!");
        Console.WriteLine($"Today {warrior1} will battle against {warrior2}! \n");

        bool warriorToStart = (die.Roll() <= die.GetSidesCount() / 2);

        if (warriorToStart)
        {
            // switching places
            w1 = warrior2;
            w2 = warrior1;
        }

        Console.WriteLine($"{w1} goes first!");
        Console.WriteLine("Let the battle begin...");
        Console.ReadKey();

        while (w1.Alive() && w2.Alive())
        {
            w1.Attack(w2);
            Render();

            PrintMessage(w1.GetLastMessage()); // attack message
            PrintMessage(w2.GetLastMessage()); // defence message

            if (w2.Alive())
            {
                w2.Attack(w1);
                Render();

                PrintMessage(w2.GetLastMessage());
                PrintMessage(w1.GetLastMessage());
            }

            Console.WriteLine();
        }
    }

    private void PrintWarrior(Warrior w)
    {
        Console.WriteLine(w);
        Console.Write("Health: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(w.HealthBar());
        Console.ResetColor();

        if (w is Mage)
        {
            Console.Write("Mana:   ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(((Mage)w).ManaBar());
            Console.ResetColor();
        }
    }
}
