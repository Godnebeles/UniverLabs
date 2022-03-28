using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class StudentRandomCreator
    {
        public string[] names = { "Vasya", "Petr", "Ivan", "Jake", "Oleg", "Pitter", "Nicka", "Jessy" };

        public string[] surnames = { "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Parker", "Lopez" };

        public string[] exams = { "Algebra", "Biology", "Drawing", "Chemistry", "Geography", "Geometry", "Physics" };

        public EducationalLevels[] educationalLevels = Enum.GetValues(typeof(EducationalLevels)).Cast<EducationalLevels>().ToArray();

        public Person GetRandomPerson()
        {
            Random random = new Random();

            Person person = new Person(
                names[random.Next(0, names.Length)],
                surnames[random.Next(0, surnames.Length)],
                new DateTime(2020, random.Next(1, 12), random.Next(1, 28))
                );

            return person;
        }

        public List<Exam> GetRandomExams()
        {
            Random random = new Random();

            List<Exam> listExam = new List<Exam>();

            for (int i = 0; i < random.Next(1, exams.Length); i++)
            {
                listExam.Add(new Exam(
                exams[i],
                new DateTime(2020, random.Next(1, 12), random.Next(1, 28)),
                random.Next(0, 100)
                ));
            }

            return listExam;
        }

        public EducationalLevels GetRandomEducationalLevel()
        {
            Random random = new Random();

            return educationalLevels[random.Next(0, educationalLevels.Length)];
        }

        public Student[] GetRandomStudents()
        {
            Random random = new Random();

            Student[] students = new Student[random.Next(1, 10)];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(GetRandomPerson(), GetRandomEducationalLevel(), GetRandomExams());
            }

            return students;
        }

    }
}
