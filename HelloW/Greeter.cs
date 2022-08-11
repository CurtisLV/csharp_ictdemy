using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloW
{
    internal class Greeter
    {
        public void Greet(string name = "World")
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
