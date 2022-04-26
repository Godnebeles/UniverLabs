using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Storage
    {
        public Dictionary<Ingredient, int> Ingredients { get; private set; }

        public Storage()
        {
            Ingredients = new Dictionary<Ingredient, int>();
        }

        public Storage(Dictionary<Ingredient, int> ingredients)
        {
            Ingredients = ingredients;
        }

        public int GetCountDishCanCook(List<Ingredient> ingredientsList)
        {
            int totalCount = 0;

            foreach(var neenedIngredient in ingredientsList)
            {
                foreach(var ingredientKey in Ingredients.Keys)
                {
                    if(neenedIngredient.Name == ingredientKey.Name)
                    {
                        int count = Ingredients[ingredientKey];

                        if(count == 0)
                            return 0;
                        else
                        {
                            if(totalCount == 0)
                                totalCount = count;
                            else
                                totalCount = count < totalCount ? count : totalCount;
                        }
                    }
                }
                if (totalCount == 0)
                    return 0;
            }

            return totalCount;
        }

    }
}
