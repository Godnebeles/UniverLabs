using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class BudgetCalculator
    {
        public List<double> Taxes { get; private set; }

        public BudgetCalculator()
        {

        }

        public BudgetCalculator(List<double> taxes)
        {
            Taxes = taxes;
        }   

        private double CalculateTotalCost(List<Budget> budgets)
        {
            double totalCost = 0;

            foreach (var budget in budgets)
            {
                totalCost += budget.Price;
            }

            return totalCost;
        }

        public double CalculateEarnings(Dictionary<DateTime, List<Dish>> dishesLists)
        {
            double totalEarnings = 0;

            foreach(var dishesList in dishesLists.Values)
            {
                
                foreach(var dish in dishesList)
                {
                    totalEarnings += dish.Price;
                    foreach(var ingredient in dish.Ingredients)
                    {
                        totalEarnings -= ingredient.Price;
                    }
                }

            }

            foreach (var taxe in Taxes)
            {
                totalEarnings -= taxe;
            }

            return totalEarnings;
        }


        
    }
}
