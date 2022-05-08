using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class StorageDTO
    {
        [JsonProperty("ingredient_list")]
        public HashSet<RecipeIngredientDTO> Ingredients { get; set; } = new HashSet<RecipeIngredientDTO>();
       
        [JsonProperty("menu")]
        public List<DishDTO> Menu { get; set; } = new List<DishDTO>();
    }
}
