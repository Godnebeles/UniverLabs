using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Storage : IStorage
    {
        public HashSet<RecipeIngredient> Ingredients { get; private set; }
        public List<Dish> Menu = new List<Dish>();

        public Storage()
        {
            Ingredients = new HashSet<RecipeIngredient>();
        }

        public Storage(HashSet<RecipeIngredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public int GetCountDishCanCook(HashSet<RecipeIngredient> ingredientsList)
        {
            int totalCount = 0;

            foreach (var neenedIngredient in ingredientsList)
            {
                if (!Ingredients.Contains(neenedIngredient))
                {
                    return 0;
                }

                RecipeIngredient ingredient1;
                RecipeIngredient ingredient2;
                Ingredients.TryGetValue(neenedIngredient, out ingredient1);
                ingredientsList.TryGetValue(neenedIngredient, out ingredient2);

                int count = Convert.ToInt32(ingredient1.Weight.Amount  /
                                            ingredient2.Weight.Amount);

                if (count <= 0)
                    return 0;

                if (totalCount == 0)
                    totalCount = count;
                else
                    totalCount = count < totalCount ? count : totalCount;  
            }

            return totalCount;
        }

    }
}
