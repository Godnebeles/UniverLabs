using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class IngredientWeight : IEquatable<IngredientWeight>
    {  
        public Ingredient Ingredient { get; private set; }

        public Weight Weight { get; private set; }

        public IngredientWeight(Ingredient ingredient, Weight weight)
        {
            Ingredient = ingredient;
            Weight = weight;
        }

        public bool Equals(IngredientWeight? other)
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
