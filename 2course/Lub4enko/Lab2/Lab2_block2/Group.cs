using System;
using System.Collections.Generic;

namespace Lab2_block2
{
    class Group
    {
        private List<Student> students = new List<Student>();

        public Group(Student s1)
        {
            students.Add(s1);
        }

        public Group(Student s1, Student s2)
        {
            students.Add(s1);
            students.Add(s2);
        }

        public Group(Student s1, Student s2, Student s3)
        {
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
        }

        public Group(Student s1, Student s2, Student s3, Student s4)
        {
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
        }

        public void PrintInfo()
        {
            if(students.Count < 4)
                Console.WriteLine("Група повинна складатися з чотирьох або більше студентів.");
            else
            {
                foreach(var student in students)
                {
                    Console.WriteLine("=======");
                    student.Study();
                    student.Program();
                    student.PlayFootball();
                    Console.WriteLine("=======");
                }
            }
        }
    }
}
