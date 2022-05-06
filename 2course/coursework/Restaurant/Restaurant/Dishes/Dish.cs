using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Dish : Ingredient
    {
        public Dictionary<Ingredient, Weight> Recipe { get; private set; }  

        public Dish(string name, double price, Weight weight) : base(name, price, weight)
        {
            Recipe = new Dictionary<Ingredient, Weight>();
        }

        public Dish(string name, double price, Weight weight, Dictionary<Ingredient, Weight> ingredients) : base(name, price, weight)
        {
            Recipe = ingredients;
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            Recipe.Remove(ingredient);
        }

        public void ChangeWeightNeededIngredient(Ingredient ingredient, Weight newWeight)
        {
            if (Recipe.ContainsKey(ingredient))
            {
                Recipe[ingredient] = newWeight;
            }
        }

        public void AddIngredientInRecipe(Ingredient ingredient, Weight weight)
        {
            if(!Recipe.ContainsKey(ingredient))
            {
                Recipe.Add(ingredient, weight);
            }
        }
    }
}
