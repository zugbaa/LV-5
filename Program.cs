using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("paket");
            Product product = new Product("NBA jersey", 750, 1);
            Product pro = new Product("PG3 shoes", 900, 4);
            box.Add(product);
            box.Add(pro);


            ShippingService price = new ShippingService(4);
        

            Console.WriteLine(price.ToString() + price.Price(box.Weight) + " hrk");

        }
    }
}
