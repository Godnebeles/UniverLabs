using MyLibrary;
using Newtonsoft.Json;
using Newtonsoft;
using System;
using System.Collections.Generic;

namespace Education
{
    public class Education
    {
        private string _path = "json_for_example.json";

        public Education()
        {
            GenerateJson();
        }

        public void GenerateJson()
        {
            StudentAdapter studentAdapter = new StudentAdapter();

            Person person1 = new Person("Petr", "Ivanov", DateTime.Now);
            Person person2 = new Person("Vasiliy", "Petrovich", DateTime.Now);

            List<Exam> examList = new List<Exam>();
            examList.Add(new Exam("Math", DateTime.Now, 5));
            examList.Add(new Exam("OOP", DateTime.Now, 5));
            examList.Add(new Exam("PE", DateTime.Now, 2));

            Student student1 = new Student(person1, EducationalLevels.Bachelor, examList);
            Student student2 = new Student(person2, EducationalLevels.Master, examList);

            List<StudentDTO> studentDTOs = new List<StudentDTO>();

            studentDTOs.Add(studentAdapter.ConvertToDTO(student1));
            studentDTOs.Add(studentAdapter.ConvertToDTO(student2));

            var serializator = new Serializator<List<StudentDTO>>(_path);

            serializator.Serialize(studentDTOs);
        }

        public List<Student> GetStudentsFromJson()
        {
            List<Student> students = new List<Student>();
            StudentAdapter studentAdapter = new StudentAdapter();

            var serializator = new Serializator<List<StudentDTO>>(_path);

            List<StudentDTO> studentDTOs = serializator.Deserialize();

            foreach(var studentDTO in studentDTOs)
            {
                students.Add(studentAdapter.ConvertToModel(studentDTO));
            }

            return students;
        }
    }
}
