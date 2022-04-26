using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Dish : Ingredient
    {
        public List<Ingredient> Ingredients { get; private set; }

        public Dish(string name, double weight, double price) : base(name, weight, price)
        {
            Ingredients = new List<Ingredient>();
        }

        public Dish(string name, double weight, double price, List<Ingredient> ingredients) : base(name, weight, price)
        {
            Ingredients = ingredients;
        }


    }
}
