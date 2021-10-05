using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExE
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> numbers = new SortedSet<int>();
            List<string> answers = new List<string>();

            using (StreamReader file = new StreamReader("input.txt", System.Text.Encoding.Default))
            {
                int size = int.Parse(file.ReadLine());

                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    string[] cmdElements = line.Split();
                    if (cmdElements[0] == "ADD")
                    {
                        numbers.Add(int.Parse(cmdElements[1]));
                    }
                    else if (cmdElements[0] == "PRESENT")
                    {
                        if (numbers.Contains(int.Parse(cmdElements[1])))
                            answers.Add("YES");
                        else
                            answers.Add("NO");
                    }
                    else if (cmdElements[0] == "COUNT")
                    {
                        answers.Add(Convert.ToString(numbers.Count));
                    }
                }
            }


            using (StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in answers)
                    sw.WriteLine(item);
            }
        }
    }
}
