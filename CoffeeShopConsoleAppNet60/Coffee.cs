using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount { get; set; }


        // Konstruktør til Discount
        public Coffee(int discount)
        {
            Discount = discount;
        }


        // Da denne klasse er en abstrakt klasse bruges virtual, fordi den kan overskrives.
        public virtual int Price()
        {
            return 20;
        }


        public int PriceWithDiscount()
        {
            return Price() - (Price() * Discount / 100);
        }

        public abstract string Strength();
    }
}
