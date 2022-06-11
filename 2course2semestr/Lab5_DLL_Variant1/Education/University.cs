using MyLibrary;
using MyLibrary.DTO;
using MyLibrary.Models;

namespace Education
{
    public class University
    {
        private StudentRandomCreator _studentRandomCreator;
        private string _path = "json_for_example.json";

        public University()
        {
            _studentRandomCreator = new StudentRandomCreator();
        }

        public void SaveStudentsToJson()
        {
            StudentAdapter studentAdapter = new StudentAdapter();

            Student[] studentModels = _studentRandomCreator.GetRandomStudents();
            
            StudentDTO[] studentDTOs = new StudentDTO[studentModels.Length];

            for (int i = 0; i < studentModels.Length; i++)
            {
                studentDTOs[i] = studentAdapter.ConvertToDTO(studentModels[i]);
            }

            var serializator = new Serializator<StudentDTO[]>(_path);

            serializator.Serialize(studentDTOs);
        }

        public Student[] GetStudentsFromJson()
        {
            StudentAdapter studentAdapter = new StudentAdapter();

            var serializator = new Serializator<StudentDTO[]>(_path);

            StudentDTO[] studentDTOs = serializator.Deserialize();

            Student[] studentModels = new Student[studentDTOs.Length];

            for (int i = 0; i < studentModels.Length; i++)
            {
                studentModels[i] = studentAdapter.ConvertToModel(studentDTOs[i]);
            }

            return studentModels;
        }
    }
}
