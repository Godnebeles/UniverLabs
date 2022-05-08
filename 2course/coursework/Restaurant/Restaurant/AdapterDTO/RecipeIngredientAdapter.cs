using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class RecipeIngredientAdapter : IAdapter<RecipeIngredient, RecipeIngredientDTO>
    {
        public RecipeIngredientDTO ConvertToDTO(RecipeIngredient model)
        {
            IAdapter<Ingredient, IngredientDTO> ingredientAdapter = new IngredientAdapter();
            IAdapter<Weight, WeightDTO> weightAdapter = new WeightAdapter();

            return new RecipeIngredientDTO()
            {
                Ingredient = ingredientAdapter.ConvertToDTO(model.Ingredient),
                Weight = weightAdapter.ConvertToDTO(model.Weight)
            };
        }

        public RecipeIngredient ConvertToModel(RecipeIngredientDTO dto)
        {
            IAdapter<Ingredient, IngredientDTO> ingredientAdapter = new IngredientAdapter();
            IAdapter<Weight, WeightDTO> weightAdapter = new WeightAdapter();

            return new RecipeIngredient(ingredientAdapter.ConvertToModel(dto.Ingredient),
                                        weightAdapter.ConvertToModel(dto.Weight));
        }
    }
}
