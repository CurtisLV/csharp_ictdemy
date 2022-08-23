﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree;

internal class Person
{
    private string name;
    public Person mother;
    public Person father;

    public Person(string name, Person father, Person mother)
    {
        this.name = name;
        this.mother = mother;
        this.father = father;
    }

    public override string ToString()
    {
        return name;
    }
}
