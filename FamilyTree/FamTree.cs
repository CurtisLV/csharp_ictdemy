using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree;

internal class FamTree
{
    private Person root;

    public FamTree(Person root)
    {
        this.root = root;
    }

    public void PrintPersonAndAncestor(Person person)
    {
        if (person != null)
        {
            Console.WriteLine(person);
            PrintPersonAndAncestor(person.father);
            PrintPersonAndAncestor(person.mother);
        }
    }

    public void Print()
    {
        Console.WriteLine($"Family tree for {root}");
        PrintPersonAndAncestor(root);
    }
}
