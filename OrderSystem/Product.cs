using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Product(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
