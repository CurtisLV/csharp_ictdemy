using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRun;

internal class Human
{
    private string name;
    public int age;
    private int tiredness = 0;


    public void Run(int distance)
    {
       if (tiredness + distance > 20)
        {
            Console.WriteLine("I'm too tired!");
        } else 
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
