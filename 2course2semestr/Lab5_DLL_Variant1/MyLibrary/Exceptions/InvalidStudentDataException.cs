using System;
using MyLibrary.Models;

namespace MyLibrary.Exceptions
{
    public class InvalidStudentDataException : Exception
    {
        public InvalidStudentDataException() { }

        public InvalidStudentDataException(EducationalLevels level) : base(String.Format($"Invalid educational level: \"{level}\" "))
        {

        }
    }
}
