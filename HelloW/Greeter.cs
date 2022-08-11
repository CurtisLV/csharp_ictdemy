using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloW
{
    internal class Greeter
    {
        public string? text;
        public string Greet(string name = "World")
        {
            return $"{text}, {name}!";
        }
    }
}
