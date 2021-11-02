using System;
using System.Collections.Generic;
using System.IO;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //HashSet<int> numbers = new HashSet<int>();
            //List<string> answers = new List<string>();

           

            //using (StreamReader file = new StreamReader("input.txt", System.Text.Encoding.Default))
            //{
            //    int size = int.Parse(file.ReadLine());

            //    string line = "";
            //    while ((line = file.ReadLine()) != null)
            //    {
            //        string[] cmdElements = line.Split();
            //        if (cmdElements[0] == "ADD")
            //        {
            //            numbers.Add(int.Parse(cmdElements[1]));
            //        }
            //        else if (cmdElements[0] == "PRESENT")
            //        {
            //            if (numbers.Contains(int.Parse(cmdElements[1])))
            //                answers.Add("YES");
            //            else
            //                answers.Add("NO");
            //        }
            //        else if (cmdElements[0] == "COUNT")
            //        {
            //            answers.Add(Convert.ToString(numbers.Count));
            //        }
            //    }
            //}


            //using (StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.Default))
            //{
            //    foreach (var item in answers)
            //        sw.WriteLine(item);
            //}
        }
    }
}
