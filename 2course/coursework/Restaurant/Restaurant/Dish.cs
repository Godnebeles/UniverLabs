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

        public Dish(string name, double price) : base(name, price)
        {
            Ingredients = new List<Ingredient>();
        }

        public Dish(string name, double price, List<Ingredient> ingredients) : base(name, price)
        {
            Ingredients = ingredients;
        }


    }
}
