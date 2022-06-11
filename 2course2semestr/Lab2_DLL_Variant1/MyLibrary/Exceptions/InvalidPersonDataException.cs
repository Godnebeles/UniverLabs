using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Exceptions
{
    public class InvalidPersonDataException : Exception
    {
        public InvalidPersonDataException() { }

        public InvalidPersonDataException(string name, string surname) : base(String.Format($"Invalid person full name: name = \"{name}\", surname = \"{surname}\" "))
        {

        }
    }
}
