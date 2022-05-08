using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class CookingPlanDTO
    {
        [JsonProperty("orders")]
        public Dictionary<DateTimeContainerDTO, Dictionary<DishDTO, int>> Orders { get; set; } = new Dictionary<DateTimeContainerDTO, Dictionary<DishDTO, int>>();
    }
}
