using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAndGetHashCode;

internal class Customer
{

    public string name;
    public string surname;
    public DateTime birthDate;

    public Customer(string name, string surname, DateTime birthDate)
    {
        this.name = name;
        this.surname = surname;
        this.birthDate = birthDate;
    }

    // overriding the Equals() method
    public override bool Equals(object? obj)
    {
        // check the object type and value using an overriden operator
        return ((obj is Customer) && (this == (Customer)obj));
    }

    // overloading the == operator (which does not use Equals())
    public override bool operator ==(Customer a, Customer b)
    {
        return ((a.name == b.name) && (a.surname == b.surname) && (a.birthDate == b.birthDate));
    }

    // when we overload the == operator, we have to overload the != operator as well.
    public static bool operator !=(Customer a, Customer b)
    {
        return !(a == b);
    }

    // overriding the object hash code generation method (doing so is necessary when overriding the Equals() method )
    public override int GetHashCode()
    {
        // ^ is bitwise exclusive OR
        return name.GetHashCode() ^ surname.GetHashCode() ^ birthDate.GetHashCode();
    }


}
