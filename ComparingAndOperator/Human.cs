using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingAndOperator;

internal abstract class Human : IComparable 
{

    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    private static Random random = new Random();
    public Human(string name, string lastName, DateTime birthDate)
    {
        Name = name;
        LastName = lastName;
        BirthDate = birthDate;
    }

    public int CompareTo(object obj)
    {
        Human other = obj as Human;

        if (Name == other.Name && LastName == other.LastName)
        {
            return BirthDate.CompareTo(other.BirthDate);
        }
        return Name.CompareTo(other.Name);
    }

    // overload + operator
    public static Human operator +(Human human1, Human human2)
    {
        if (human1.GetType() == human2.GetType())
        {
            return null;
        }

        Man man = (human1 is Man) ? (Man)human1 : (Man)human2;
        Woman woman = (human1 is Woman) ? (Woman)human1 : (Woman)human2;

        if (random.Next(2) == 0)
        {
            return new Man("Adam", man.LastName, DateTime.Now);
        }
        return new Woman("Eve", woman.LastName, DateTime.Now);
    }

    // override ToString()
    public override string ToString()
    {
        return $"{Name} {LastName} {BirthDate.ToString("yy")}";
    }
}
