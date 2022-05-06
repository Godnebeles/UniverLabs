using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DishAdapter : IAdapter<Dish, DishDTO>
    {
        public DishDTO ConvertToDTO(Dish model)
        {
            DishDTO dto = new DishDTO();

            dto.Id = model.Id;
            dto.WeightInOneServing = model.WeightInOneServing;
            dto.PricePerServing = model.PricePerServing;

            IAdapter<Ingredient, IngredientDTO> adapterIngredietn = new IngredientAdapter();
            IAdapter<Weight, WeightDTO> adapterWeight = new WeightAdapter();

            foreach(var item in model.Recipe)
            {
                dto.Recipe.Add(adapterIngredietn.ConvertToDTO(item.Key), adapterWeight.ConvertToDTO(item.Value));
            }

            return dto;
        }

        public Dish ConvertToModel(DishDTO dto)
        {
            Dish model = new Dish(dto.Id, dto.Name, dto.PricePerServing, dto.WeightInOneServing);

            IAdapter<Ingredient, IngredientDTO> adapterIngredietn = new IngredientAdapter();
            IAdapter<Weight, WeightDTO> adapterWeight = new WeightAdapter();

            foreach (var item in dto.Recipe)
            {
                model.AddIngredientInRecipe(adapterIngredietn.ConvertToModel(item.Key), adapterWeight.ConvertToModel(item.Value));
            }

            return model;
        }
    }
}
