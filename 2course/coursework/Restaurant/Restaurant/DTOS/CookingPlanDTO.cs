using Newtonsoft.Json;
using System.Collections.Generic;


namespace Restaurant
{
    public class CookingPlanDTO
    {
        [JsonProperty("orders")]
        public HashSet<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
