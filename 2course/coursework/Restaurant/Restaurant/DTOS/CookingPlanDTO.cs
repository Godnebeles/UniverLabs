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
        [JsonProperty("date_time")]
        public Dictionary<DateTimeContainerDTO, Dictionary<DishDTO, int>> Orders { get; set; }
    }
}
