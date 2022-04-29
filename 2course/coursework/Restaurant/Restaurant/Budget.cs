using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Budget
    {
        public abstract double Price { get;  set; }
      
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
