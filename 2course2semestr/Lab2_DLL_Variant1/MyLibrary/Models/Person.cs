using System;

namespace MyLibrary
{
    public class Person : IComparable<Person>, ICloneable
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

        private enum SortFields
        {
            Name,
            Surname
        }

        public override string ToString()
        {
            return $"Name: {Name} | Surname: {Surname} | Date of Birth: {Birthday}";
        }

        public int CompareTo(Person other)
        {
            int compareResult = 0;

            foreach (var item in Enum.GetValues(typeof(SortFields)))
            {
                switch (item)
                {
                    case SortFields.Name:
                        compareResult = string.Compare(Name, other.Name, StringComparison.Ordinal);
                        break;

                    case SortFields.Surname:
                        compareResult = string.Compare(Surname, other.Surname, StringComparison.Ordinal);
                        break;
                }

                if (compareResult != 0)
                    break;
            }

            return compareResult;
        }

        public object Clone()
        {
            return new Person(Name, Surname, Birthday);
        }

        
    }
}
