using System;

namespace MyLibrary
{
    public class Exam : IComparable<Exam>, ICloneable
    {
        public string Title { get; private set; }
        public int Mark { get; private set; }
        public DateTime Date { get; private set; } 

        public Exam(string title, int mark, DateTime date)
        {
            Title = title;
            Mark = mark;
            Date = date;
        }

        public override string ToString()
        {
            return $"Title: {Title} | Grade: {Mark} | Date of Passed: {Date}";
        }

        public int CompareTo(Exam other)
        {
            return string.Compare(Title, other.Title, StringComparison.Ordinal);
        }

        public object Clone()
        {
            return new Exam(Title, Mark, Date);
        }

    }
}
