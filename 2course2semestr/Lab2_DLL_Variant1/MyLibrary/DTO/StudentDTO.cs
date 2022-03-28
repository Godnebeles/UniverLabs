using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyLibrary
{
    public class StudentDTO
    {
        [JsonProperty("person")]
        public PersonDTO PersonInfo { get; set; }

        [JsonProperty("level_to_obtain")]
        public EducationalLevels LevelToObtain { get; set; }

        [JsonProperty("list_passed_exams")]
        public List<ExamDTO> PassedExams { get; set; } = new List<ExamDTO>();
    }
}
