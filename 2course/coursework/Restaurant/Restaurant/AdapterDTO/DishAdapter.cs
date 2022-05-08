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
            IAdapter<Ingredient, IngredientDTO> adapterIngredietn = new IngredientAdapter();
            IAdapter<Weight, WeightDTO> adapterWeight = new WeightAdapter();

            DishDTO dto = new DishDTO();

            dto.Id = model.Id;
            dto.WeightInOneServing = adapterWeight.ConvertToDTO(model.WeightInOneServing);
            dto.PricePerServing = model.PricePerServing;

            foreach(var item in model.Recipe)
            {
                dto.Recipe.Add(adapterIngredietn.ConvertToDTO(item.Key), adapterWeight.ConvertToDTO(item.Value));
            }

            return dto;
        }

        public Dish ConvertToModel(DishDTO dto)
        {
            IAdapter<Ingredient, IngredientDTO> adapterIngredietn = new IngredientAdapter();
            IAdapter<Weight, WeightDTO> adapterWeight = new WeightAdapter();

            Dish model = new Dish(dto.Id, dto.Name, dto.PricePerServing, adapterWeight.ConvertToModel(dto.WeightInOneServing));       

            foreach (var item in dto.Recipe)
            {
                model.AddIngredientInRecipe(adapterIngredietn.ConvertToModel(item.Key), adapterWeight.ConvertToModel(item.Value));
            }

            return model;
        }
    }
}
