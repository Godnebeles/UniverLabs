using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Exceptions
{
    public class InvalidExamDataException : Exception
    {
        public InvalidExamDataException() { }

        public InvalidExamDataException(string name) : base(String.Format($"Invalid exam name: \"{name}\" "))
        {

        }

        public InvalidExamDataException(int mark) : base(String.Format($"Invalid exam mark: \"{mark}\" "))
        {

        }
    }
}
