using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Storage
    {
        public Dictionary<string, int> Ingredients { get; private set; }

        public Storage()
        {
            Ingredients = new Dictionary<string, int>();
        }

        public Storage(Dictionary<string, int> ingredients)
        {
            Ingredients = ingredients;
        }

        public int GetCountDishCanCook(List<Ingredient> ingredientsList)
        {
            int totalCount = 0;

            foreach (var neenedIngredient in ingredientsList)
            {
                if (!Ingredients.ContainsKey(neenedIngredient.Name))
                {
                    return 0;
                }

                int count = Convert.ToInt32(Ingredients[neenedIngredient.Name]  / neenedIngredient.Weight);

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
