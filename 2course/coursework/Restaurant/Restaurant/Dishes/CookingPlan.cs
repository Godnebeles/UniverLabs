using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class CookingPlan
    {
        public Dictionary<DateTimeContainer, Dictionary<Dish, int>> Orders { get; private set; }

        public CookingPlan()
        {
            Orders = new Dictionary<DateTimeContainer, Dictionary<Dish, int>>();
        }  

        public void AddOrder(DateTimeContainer dateTime, Dish dish, int count)
        {
            if (Orders.ContainsKey(dateTime))
                if(Orders[dateTime].ContainsKey(dish))
                    Orders[dateTime][dish] += count;
                else
                    Orders[dateTime].Add(dish, count);
            else
            {
                Dictionary<Dish, int> keyValuePair = new Dictionary<Dish, int>();
                keyValuePair.Add(dish, count);
                Orders.Add(dateTime, keyValuePair);
            }     
        }

    }
}
