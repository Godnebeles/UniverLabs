using MyLibrary.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    public class Exam : IComparable<Exam>, ICloneable
    {
        private const int MIN_MARK = 0;
        private const int MAX_MARK = 100;

        public string Title { get; private set; }

        [Range(0, 100, ErrorMessage = "Invalid Mark, it must be from 0 to 100")]
        public int Mark { get; private set; }
        public DateTime Date { get; private set; } 

        public Exam(string title, int mark, DateTime date)
        {
            if (title == null || title == "")
            {
                throw new InvalidExamDataException(title);
            }
            if (mark < MIN_MARK || mark > MAX_MARK)
            {
                throw new InvalidExamDataException(mark);
            }

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
