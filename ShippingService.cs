using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class ShippingService
    {
        private double jm;

        public ShippingService(double jm) { this.jm = jm; }

        public double Price(double weight)
        {
            return jm * weight;
        }

        public override string ToString()
        {
            return "Ukupna cijena dostave je:";
        }
    }
}
