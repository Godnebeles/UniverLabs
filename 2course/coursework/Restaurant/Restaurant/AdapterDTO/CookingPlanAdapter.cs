using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class CookingPlanAdapter : IAdapter<CookingPlan, CookingPlanDTO>
    {
        public CookingPlanDTO ConvertToDTO(CookingPlan model)
        {
            IAdapter<DateTimeContainer, DateTimeContainerDTO> dateTimeAdapter = new DateTimeContainerAdapter();
            IAdapter<Dish, DishDTO> dishAdapter = new DishAdapter();

            CookingPlanDTO cookingPlanDTO = new CookingPlanDTO();

            foreach (var order in model.Orders)
            {
                DateTimeContainerDTO currentKey = dateTimeAdapter.ConvertToDTO(order.Key);
                cookingPlanDTO.Orders.Add(currentKey, new Dictionary<DishDTO, int>());
               
                foreach (var dishKeyValue in order.Value)
                {
                    cookingPlanDTO.Orders[currentKey].Add(dishAdapter.ConvertToDTO(dishKeyValue.Key), dishKeyValue.Value);
                }
            }

            return cookingPlanDTO;
        }

        public CookingPlan ConvertToModel(CookingPlanDTO dto)
        {
            IAdapter<DateTimeContainer, DateTimeContainerDTO> dateTimeAdapter = new DateTimeContainerAdapter();
            IAdapter<Dish, DishDTO> dishAdapter = new DishAdapter();

            CookingPlan cookingPlan = new CookingPlan();

            foreach (var order in dto.Orders)
            {
                DateTimeContainer currentKey = dateTimeAdapter.ConvertToModel(order.Key);
                cookingPlan.Orders.Add(currentKey, new Dictionary<Dish, int>());

                foreach (var dishKeyValue in order.Value)
                {
                    cookingPlan.AddOrder(currentKey, dishAdapter.ConvertToModel(dishKeyValue.Key), dishKeyValue.Value);
                }
            }

            return cookingPlan;
        }
    }
}
