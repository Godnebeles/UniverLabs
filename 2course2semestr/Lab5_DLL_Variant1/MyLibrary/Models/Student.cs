using MyLibrary.Exceptions;
using System;
using System.Collections.Generic;

namespace MyLibrary.Models
{
    public class Student : IComparable<Student>, ICloneable
    {
        public Person PersonInfo { get; private set; }
        public EducationalLevels LevelToObtain { get; private set; }

        private List<Exam> _passedExams;
        public List<Exam> PassedExams {
            get
            {
                List<Exam> newExams = new List<Exam>();
                _passedExams.ForEach((exam) => { newExams.Add(exam);});
                return newExams;
            } 
            private set 
            {
                _passedExams = value;
            } 
        }

        public Student(Person person, EducationalLevels levelToObtain)
        {
            if (!Enum.IsDefined(typeof(EducationalLevels), levelToObtain))
            {
                throw new InvalidStudentDataException(levelToObtain);
            }

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
            _passedExams.Add(exam);
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
                totalGrade += exam.Mark;
            }

            return totalGrade / PassedExams.Count;
        }

        public int CompareTo(Student other)
        {
            return PersonInfo.CompareTo(other.PersonInfo);
        }

        public object Clone()
        {
            return new Student((Person)PersonInfo.Clone(), LevelToObtain, PassedExams);
        }
    }
}
