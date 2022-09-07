using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class Order : IOrder
    {
        public int Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int RegistryNumber { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string[] Products { get; set; }

        public int[] Quantities { get; set; }

        public double[] Prices { get; set; }
    }
}
