using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class CookingPlan
    {
        public Dictionary<DateTimeContainer, List<Dish>> Orders { get; private set; }

        public CookingPlan()
        {

        }

        public CookingPlan(Dictionary<DateTimeContainer, List<Dish>> orders)
        {
            
        }     

        public void AddOrder(DateTimeContainer dateTime, Dish dish)
        {
            if (Orders.ContainsKey(dateTime))
                Orders[dateTime].Add(dish);
            else
            {
                List<Dish> dishes = new List<Dish>();
                dishes.Add(dish);
                Orders.Add(dateTime, dishes);
            }                
        }

    }
}
