using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class Address
    {
        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int RegistryNumber { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public Address(string street, int houseNumber, int registryNumber, string city, string zipCode)
        {
            Street = street;
            HouseNumber = houseNumber;
            RegistryNumber = registryNumber;
            City = city;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Street} {HouseNumber}/{RegistryNumber}, {City}";
        }
    }
}
