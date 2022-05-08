using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public interface IStorage
    {
        int GetCountDishCanCook(HashSet<RecipeIngredient> ingredientsList);
    }
}
