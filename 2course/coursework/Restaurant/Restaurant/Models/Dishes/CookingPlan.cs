using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class CookingPlan
    {
        public HashSet<Order> Orders { get; private set; }

        public CookingPlan()
        {
            Orders = new HashSet<Order>();
        }

        public CookingPlan(HashSet<Order> orders)
        {
            Orders = orders;
        }


        public void AddOrder(Order newOrder)
        {
            if(!Orders.Contains(newOrder))
            {
                Orders.Add(newOrder);
            }
        }

    }
}
