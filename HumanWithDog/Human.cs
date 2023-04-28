using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWithDog;

internal class Human
{
    private string name;
    public Dog dog;

    public Human(string name, Dog dog)
    {
        this.name = name;
        this.dog = dog;
    }
}
