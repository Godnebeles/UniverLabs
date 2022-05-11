using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order : IEquatable<Order>
    {
        public DateTimeContainer Date { get; protected set; }

        public HashSet<DishCount> Dishes { get; protected set; }

        public Order(DateTimeContainer date)
        {
            Date = date;
            Dishes = new HashSet<DishCount>();
        }

        public Order(DateTimeContainer date, DishCount dish)
        {
            Date = date;
            Dishes = new HashSet<DishCount>();
            Dishes.Add(dish);
        }

        public void AddDish(DishCount dish)
        {
            if (!Dishes.Contains(dish))
            {
                Dishes.Add(dish);
            }
        }

        public void ChangeCountDish(DishCount dish)
        {
            if(Dishes.Contains(dish))
            {
                Dishes.Remove(dish);
                Dishes.Add(dish);
            }
        }

        public void RemoveDish(DishCount dish)
        {
            if(Dishes.Contains(dish))
            {
                Dishes.Remove(dish);
            }
        }

        public bool Equals(Order? other)
        {
            if (other == null)
                return false;

            return Date.Equals(other.Date);
        }

        public override int GetHashCode()
        {
            return Date.GetHashCode();
        }
    }
}
