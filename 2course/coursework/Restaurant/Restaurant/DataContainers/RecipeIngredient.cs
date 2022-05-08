using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class RecipeIngredient : IEquatable<RecipeIngredient>
    {  
        public Ingredient Ingredient { get; private set; }

        public Weight Weight { get; private set; }

        public RecipeIngredient(Ingredient ingredient, Weight weight)
        {
            Ingredient = ingredient;
            Weight = weight;
        }

        public bool Equals(RecipeIngredient? other)
        {
            if (other == null)
                return false;

            return Ingredient.Id.Equals(other.Ingredient.Id);
        }

        public override int GetHashCode()
        {
            return Ingredient.Id.GetHashCode();
        }
    }
}
