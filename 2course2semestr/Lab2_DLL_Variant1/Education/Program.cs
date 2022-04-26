using System;
using MyLibrary;

namespace Education
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                Console.Clear();
        
                if(key.Key == ConsoleKey.C)
                {
                    university.SaveStudentsToJson();
                    Console.WriteLine("Students Created");
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Student[] students = university.GetStudentsFromJson();

                    Array.Sort(students);

                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                    }
                }
                else if(key.Key == ConsoleKey.S)
                {
                    Student[] students = university.GetStudentsFromJson();
                    
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student.ToStringShort());
                    }
                }
                else
                {
                    break;
                }
                    
            }

            Console.ReadLine();
        }
    }
}
