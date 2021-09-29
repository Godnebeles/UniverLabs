using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tresh
{
    struct Person : IComparable<Person>
    {
        private string lastName, firstName;
        private char classLetter;
        private int classNumber;
        private DateTime birthday;
        private string[] whatSort;

        public Person(string _lastName, string _firstName, string _classRoom, DateTime _birthday, string[] whatSort)
        {
            lastName = _lastName;
            firstName = _firstName;
            classNumber = (_classRoom.Length == 3) ? (Convert.ToInt32(_classRoom[0]) - Convert.ToInt32('0')) * 10 + (Convert.ToInt32(_classRoom[1]) - Convert.ToInt32('0')) : (Convert.ToInt32(_classRoom[0]) - Convert.ToInt32('0'));
            classLetter = (_classRoom.Length == 3) ? _classRoom[2] : _classRoom[1];
            birthday = _birthday;
            this.whatSort = whatSort;
        }

        
            /*
                surname — за прізвищем, ігноруючи ім'я;
                fullname — за прізвищем, а при однаковості прізвищ — за ім'ям;
                birthyear — за роком народження, ігноруючи дату всередині року, від менших дат (старших учнів) до більших дат (молодших учнів);
                birthdate — за датою народження, включаючи рік, від менших дат (старших учнів) до більших дат (молодших учнів);
                birthday — за днем народження, тобто вважаючи рівними однакові день і місяць різних років, від 01.01 до 31.12 (у календарному смислі);
                grade — за класом як номером року навчання, від 1 до 11, ігноруючи букву;
                class — спочатку за класом як номером року навчання, а при однаковості — за буквою класу від A до Z
            */
           
        
        public int CompareTo(Person other)
        {
            int result = 0;
            foreach(var item in whatSort)
            {
                switch (item)
                {
                    case "surname":
                        result = string.Compare(lastName, other.lastName, StringComparison.Ordinal);
                        break;
                    case "birthyear":
                        result = birthday.Year.CompareTo(other.birthday.Year);                         
                        break;
                    case "grade":
                        result = classNumber.CompareTo(other.classNumber);
                        break;
                    case "fullname":
                        result = string.Compare(lastName, other.lastName, StringComparison.Ordinal) == 0 ?
                                 string.Compare(firstName, other.firstName, StringComparison.Ordinal) : 
                                 string.Compare(lastName, other.lastName, StringComparison.Ordinal);
                        break;
                    case "birthdate":
                        result = birthday.CompareTo(other.birthday);
                        break;
                    case "birthday":
                        result = birthday.Month.CompareTo(other.birthday.Month) == 0 ? 
                            birthday.Day.CompareTo(other.birthday.Day) :
                            birthday.Month.CompareTo(other.birthday.Month);
                        break;
                    case "class":
                        result = classNumber == other.classNumber ? 
                            classLetter.CompareTo(other.classLetter) :
                            classNumber.CompareTo(other.classNumber);
                        break;

                }
                if (result != 0)
                    break;
            }
            return result;
        }
        
        public override string ToString()
        {
            return $"{classNumber}{classLetter}, {lastName}, {firstName}, {birthday.ToString("dd.MM.yy")}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people;

            using (StreamReader file = new StreamReader("input.txt", System.Text.Encoding.Default))
            {
                string[] whatSort = file.ReadLine().Split();
                int size = int.Parse(file.ReadLine());
                people = new Person[size];
                for (int i = 0; i < size; i++)
                {
                    string lastName = file.ReadLine();
                    string firstName = file.ReadLine();
                    string classRoom = file.ReadLine();
                    string[] birth = file.ReadLine().Split('.');
                    DateTime birthday = new DateTime(int.Parse(birth[2]) > 21 ?
                        int.Parse("19" + birth[2]) :
                        int.Parse("20" + birth[2]), int.Parse(birth[1]), int.Parse(birth[0]));
                    people[i] = new Person(lastName, firstName, classRoom, birthday, whatSort);
                }
            }

            Array.Sort(people);

            using (StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in people)
                    sw.WriteLine(item.ToString());
            }

        }
    }

}








