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
        Console.Clear();
        Console.WriteLine("-------------- Arena -------------- \n");
        Console.WriteLine("Warriors health: \n");
        Console.WriteLine($"{warrior1} {warrior1.HealthBar()}");
        Console.WriteLine($"{warrior2} {warrior2.HealthBar()}");
   
    }

    private void PrintMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(500);
    }


    public void Fight()
    {
        Console.WriteLine("Welcome to the Arena!");
        Console.WriteLine($"Today {warrior1} will battle against {warrior2}! \n");
        Console.WriteLine("Let the battle begin...");
        Console.ReadKey();


        while (warrior1.Alive() && warrior2.Alive())
        {
            warrior1.Attack(warrior2);
            Render();

            PrintMessage(warrior1.GetLastMessage()); // attack message
            PrintMessage(warrior2.GetLastMessage()); // defence message

            warrior2.Attack(warrior1);
            Render();

            PrintMessage(warrior1.GetLastMessage());
            PrintMessage(warrior2.GetLastMessage());

            Console.WriteLine();

        }

    }


}
