using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWithDog;

internal class Dog
{
    private string name;
    private int age = 1;

    public Dog(string name)
    {
        this.name = name;
    }

    public void GetOlder()
    {
        this.age++;
    }

    public override string ToString()
    {
        return $"{name} ({age} years)";
    }
}
