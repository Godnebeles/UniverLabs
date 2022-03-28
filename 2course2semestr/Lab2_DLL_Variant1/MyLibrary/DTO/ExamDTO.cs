using Newtonsoft.Json;
using System;

namespace MyLibrary
{
    public class ExamDTO
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("grade")]
        public int Grade { get; set; }
    }
}
