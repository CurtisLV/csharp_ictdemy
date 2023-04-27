using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloW
{
    /// <summary>
    /// A class represents a greeter whose purpose is to greet the user
    /// </summary>
    internal class Greeter
    {
        public string? text;

        public string Greet(string name = "World")
        {
            return $"{text}, {name}!";
        }
    }
}
