using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRun;

internal class Human
{
    protected string name;
    protected int age;
    protected int tiredness = 0;

    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Run(int distance)
    {
        if (tiredness + distance > 20)
        {
            Console.WriteLine("I'm too tired");
        }
        else
        {
            tiredness = tiredness + distance;
        }
    }

    public void Sleep(int hours)
    {
        tiredness -= hours * 10;

        if (tiredness < 0)
        {
            tiredness = 0;
        }
    }

    public override string ToString()
    {
        return $"{name} ({age})";
    }
}
