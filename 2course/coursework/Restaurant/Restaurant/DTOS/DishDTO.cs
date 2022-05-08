using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class DishDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("price_per_serving")]
        public double PricePerServing { get; set; }

        [JsonProperty("weight_in_one_serving")]
        public WeightDTO WeightInOneServing { get; set; }

        [JsonProperty("recipe")]
        public HashSet<RecipeIngredientDTO> Recipe { get; set; } = new HashSet<RecipeIngredientDTO>();
    }
}
