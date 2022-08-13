using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends
{
    internal class Person
    {
        public string name;
        public int age;
        public Person friend;

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {name}, I'm {age} years old and my friend is {friend}");
        }
    }
}
