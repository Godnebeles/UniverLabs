using System;

namespace MyLibrary
{
    public class Exam
    {
        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public int Grade { get; private set; }

        public Exam(string title, DateTime date, int grade)
        {
            Title = title;
            Date = date;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Title: {Title} | Grade: {Grade} | Date of Passed: {Date}";
        }
    }
}
