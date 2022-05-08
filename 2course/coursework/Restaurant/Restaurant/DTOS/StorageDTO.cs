using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class StorageDTO
    {
        public Dictionary<IngredientDTO, WeightDTO> Ingredients { get; private set; } = new Dictionary<IngredientDTO, WeightDTO>();
        public List<DishDTO> Menu = new List<DishDTO>();
    }
}
