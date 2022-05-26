using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class BudgetCalculator : IBudgetCalculator
    {
        //public List<Taxe> Taxes { get; private set; }


        //public BudgetCalculator(List<Taxe> taxes)
        //{
        //    Taxes = taxes;
        //}

        //public double CalculateEarnings(Dictionary<Dish, int> dishesList)
        //{
        //    throw new NotImplementedException();
        //}

        //private double CalculateTotalCost(List<Budget> budgets)
        //{
        //    double totalCost = 0;

        //    foreach (var budget in budgets)
        //    {
        //        totalCost += budget.PricePerServing;
        //    }

        //    return totalCost;
        //}

        //public double CalculateEarnings(Dictionary<Dish, int> dishesList)
        //{
        //    double totalEarnings = 0;


        //    foreach (var dish in dishesList)
        //    {
        //        totalEarnings += dish.Key.PricePerServing;

        //        foreach (var ingredient in dish.Key.Recipe)
        //        {
        //            totalEarnings -= ingredient.Key.GetPrice(new Weight(ingredient.Value.Amount, ingredient.Value.Unit));
        //        }
        //    }


        //    foreach (var taxe in Taxes)
        //    {
        //        totalEarnings -= taxe.Amount;
        //    }

        //    return totalEarnings;
        //}
        public double CalculateEarnings(Dictionary<Dish, int> dishesList)
        {
            throw new NotImplementedException();
        }
    }
}
