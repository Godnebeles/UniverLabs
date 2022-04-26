using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Budget
    {
        public double Price { get; private set; }
      
        public Budget(double price)
        {
            Price = price;          
        }

        public void ChangePrice(double newPrice)
        {
            if (newPrice > 0)
                Price = newPrice;
        }


    }
}
