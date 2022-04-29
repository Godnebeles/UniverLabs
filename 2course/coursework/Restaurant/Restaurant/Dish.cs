using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Dish : Ingredient
    {
        public Dictionary<Ingredient, Weight> Ingredients { get; private set; }

        public Dish(string name, double price) : base(name, price)
        {
            Ingredients = new Dictionary<Ingredient, Weight>();
        }

        public Dish(string name, double weight, double price, Dictionary<Ingredient, Weight> ingredients) : base(name, weight, price)
        {
            Ingredients = ingredients;
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            Ingredients.Remove(ingredient);
        }

        public void ChangeWeight(Ingredient ingredient, Weight newWeight)
        {
            if (Ingredients.ContainsKey(ingredient))
            {
                Ingredients[ingredient] = newWeight;
            }
        }

        public void AddIngredient(Ingredient ingredient, Weight weight)
        {
            if(!Ingredients.ContainsKey(ingredient))
            {
                Ingredients.Add(ingredient, weight);
            }
        }
    }
}
