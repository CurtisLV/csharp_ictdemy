using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;

internal class Gateway
{
    public void ProcessOrder(IOrder order)
    {
        Console.WriteLine($"Order no. {order.Number}");
        Console.WriteLine("=============");
        Console.WriteLine($"Name:    {order.FirstName} {order.LastName}");
        Console.WriteLine($"Address: {order.Street} {order.HouseNumber}/{order.RegistryNumber}");
        Console.WriteLine($"         {order.City} {order.Zip}");
        Console.WriteLine($"         {order.Country}");
        Console.WriteLine();
        for (int i = 0; i < order.Products.Length; i++)
        {
            Console.WriteLine(
                $"{order.Products[i]} {order.Quantities[i]}pcs per ${order.Prices[i]}"
            );
        }
        Console.WriteLine();
        Console.WriteLine($"Total price: ${order.Prices.Sum()}");
    }
}
