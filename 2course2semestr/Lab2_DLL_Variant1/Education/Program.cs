using System;
using System.Collections.Generic;
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

                if (key.Key != ConsoleKey.F && key.Key != ConsoleKey.S)
                {
                    break;
                }

                Console.Clear();

                university.SaveStudentsToJson();
                Student[] students = university.GetStudentsFromJson();
                
                if(key.Key == ConsoleKey.F)
                {
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student);
                    }
                }
                else
                {
                    foreach (Student student in students)
                    {
                        Console.WriteLine(student.ToStringShort());
                    }
                }
                
            }

          
        }
    }
}
