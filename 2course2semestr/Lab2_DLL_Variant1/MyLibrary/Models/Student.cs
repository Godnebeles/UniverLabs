using System.Collections.Generic;

namespace MyLibrary
{
    public class Student
    {
        public Person PersonInfo { get; private set; }
        public EducationalLevels LevelToObtain { get; private set; }
        public List<Exam> PassedExams { get; private set; }

        public Student(Person person, EducationalLevels levelToObtain)
        {
            PersonInfo = person;
            LevelToObtain = levelToObtain;
            PassedExams = new List<Exam>();
        }

        public Student(Person person, EducationalLevels levelToObtain, List<Exam> passedExams) : this (person, levelToObtain)
        {
            PassedExams = passedExams;
        }

        public void AddPassedExam(Exam exam)
        {
           PassedExams.Add(exam);
        }

        public override string ToString()
        {
            string studentInformation = $"{PersonInfo}\nEducation to obtain: {LevelToObtain}\n";

            foreach (Exam exam in PassedExams)
            {
                studentInformation += exam.ToString() + "\n";
            }

            return studentInformation;
        }

        public string ToStringShort()
        {
            return $"Surname: {PersonInfo.Surname} | Average grade: {CalcAverageGrade()}";
        }


        private float CalcAverageGrade()
        {
            int totalGrade = 0;

            foreach (var exam in PassedExams)
            {
                totalGrade += exam.Grade;
            }

            return totalGrade / PassedExams.Count;
        }   
    }
}
