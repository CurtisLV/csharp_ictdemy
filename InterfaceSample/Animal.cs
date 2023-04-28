using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal abstract class Animal : IComparable
{
    public int Weight { get; set; }

    virtual public void Breathe()
    {
        Console.WriteLine("Breathing...");
    }

    public abstract void Move(); // Abstract method

    public int CompareTo(object obj)
    {
        Animal other = (Animal)obj;
        if (this.Weight < other.Weight)
        {
            return -1;
        }
        if (this.Weight > other.Weight)
        {
            return 1;
        }
        return 0;
    }

    public static Animal operator +(Animal animal1, Animal animal2)
    {
        if (
            ((animal1 is Bird) && (animal2 is Lizard)) || ((animal2 is Bird) && (animal1 is Lizard))
        )
        {
            return new Pterodactyl() { Weight = animal1.Weight + animal2.Weight };
        }
        return null;
    }
}
