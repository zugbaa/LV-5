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
            Box box = new Box("svasta");
            Product product = new Product("ps4", 55.66, 4);
            Product pro = new Product("Atari", 55, 2);
            box.Add(product);
            box.Add(pro);


            ShippingService price = new ShippingService(4);
        

            Console.WriteLine(price.ToString() + price.Price(box.Weight) + " hrk");

        }
    }
}
