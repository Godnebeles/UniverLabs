using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Budget
    {
        public double PricePerServing { get; private set; }
        public Weight WeightInOneServing { get; private set; }

        public Budget(double pricePerServing, Weight weightInOneServing)
        {
            PricePerServing = pricePerServing;  
            WeightInOneServing = weightInOneServing;
        }

        public void ChangePrice(double newPrice)
        {
            if (newPrice > 0)
                PricePerServing = newPrice;
        }

        public void ChangeWeightInOneServing(Weight newWeight)
        {
            if (newWeight.Value > 0)
                WeightInOneServing = newWeight;            
        }
    }
}
