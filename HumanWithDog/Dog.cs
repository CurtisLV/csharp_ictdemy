using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWithDog;

internal class Dog
{
    private string name;
    private int age;

    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Age()
    {
        this.age++;
    }
}
