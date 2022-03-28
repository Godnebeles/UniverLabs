using System;

namespace MyLibrary
{
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime Birthday { get; private set; }

        public Person(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"Name: {Name} | Surname: {Surname} | Date of Birth: {Birthday}";
        }
    }
}
