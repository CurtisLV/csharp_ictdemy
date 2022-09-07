using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName {
            get; set; 
        }

        public Customer(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
