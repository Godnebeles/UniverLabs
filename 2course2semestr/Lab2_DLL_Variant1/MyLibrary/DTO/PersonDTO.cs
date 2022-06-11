using Newtonsoft.Json;
using System;

namespace MyLibrary.DTO
{
    public class PersonDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
    }
}
