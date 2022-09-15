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


}
