using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Storage : IStorage
    {
        public Dictionary<Ingredient, Weight> Ingredients { get; private set; }

        public Storage()
        {
            Ingredients = new Dictionary<Ingredient, Weight>();
        }

        public Storage(Dictionary<Ingredient, Weight> ingredients)
        {
            Ingredients = ingredients;
        }

        public int GetCountDishCanCook(Dictionary<Ingredient, Weight> ingredientsList)
        {
            int totalCount = 0;

            foreach (var neenedIngredient in ingredientsList.Keys)
            {
                if (!Ingredients.ContainsKey(neenedIngredient))
                {
                    return 0;
                }

                int count = Convert.ToInt32(Ingredients[neenedIngredient].Amount  /
                                            ingredientsList[neenedIngredient].Amount);

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
