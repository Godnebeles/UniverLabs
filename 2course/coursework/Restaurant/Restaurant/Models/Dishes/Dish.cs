using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Dish : BaseModel
    {
        public double PricePerServing { get; private set; }
        public Weight WeightInOneServing { get; private set; }
        public Dictionary<Ingredient, Weight> Recipe { get; private set; }  

        public Dish(int id, string name, double pricePerServing, Weight weightInOneServing) : base(id, name)
        {
            Recipe = new Dictionary<Ingredient, Weight>();
            WeightInOneServing = weightInOneServing;
            PricePerServing = pricePerServing;
        }

        public Dish(int id, string name, double pricePerServing, Weight weightInOneServing, Dictionary<Ingredient, Weight> recipe) : this(id, name, pricePerServing, weightInOneServing)
        {
            Recipe = recipe;
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
