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
        public HashSet<RecipeIngredient> Recipe { get; private set; }  

        public Dish(int id, string name, double pricePerServing, Weight weightInOneServing) : base(id, name)
        {
            Recipe = new HashSet<RecipeIngredient>();
            WeightInOneServing = weightInOneServing;
            PricePerServing = pricePerServing;
        }

        public Dish(int id, string name, double pricePerServing, Weight weightInOneServing, HashSet<RecipeIngredient> recipe) : this(id, name, pricePerServing, weightInOneServing)
        {
            Recipe = recipe;
        }

        public void DeleteIngredient(RecipeIngredient ingredient)
        {
            Recipe.Remove(ingredient);
        }

        public void ChangeWeightNeededIngredient(RecipeIngredient ingredient)
        {
            if (Recipe.Contains(ingredient))
            {
                Recipe.Remove(ingredient);
                Recipe.Add(ingredient);
            }
        }

        public void AddIngredientInRecipe(RecipeIngredient ingredient)
        {
            if(!Recipe.Contains(ingredient))
            {
                Recipe.Add(ingredient);
            }
        }
    }
}
