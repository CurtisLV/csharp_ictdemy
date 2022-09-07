using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample;

internal abstract class Animal: IComparable 
{
    public int Weight {
        get; set;
    }

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

}
