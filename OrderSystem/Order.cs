﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    internal class Order : IOrder
    {
        public int Number { get; private set; }

        public string FirstName {
            get {
                return customer.Name; 
            }
        }

        public string LastName {
            get {
                return customer.LastName;
            }
        }

        public string Street {
            get {
                return addressInvoice.Street;
            }
        }

        public int HouseNumber {
            get {
                return addressInvoice.HouseNumber;
            }
        }

        public int RegistryNumber {
            get {
                return addressInvoice.RegistryNumber;
            }
        }

        public string City {
            get { return addressInvoice.City; }
        }

        public string Zip {
            get {
                return addressInvoice.ZipCode;
            }
        }

        public string Country { get; set; }

        public string[] Products { get; set; }

        public int[] Quantities { get; set; }

        public double[] Prices { get; set; }

        private Customer customer;
        private Product product;
        private Address addressShipping;
        private Address addressInvoice;

        public Order(int number, Product product, Customer customer, Address addressShipping, Address addressInvoice)
        {
            Number = number;
            this.product = product;
            this.customer = customer;
            this.addressInvoice = addressInvoice;
            this.addressShipping = addressShipping;

        }
    }
}
