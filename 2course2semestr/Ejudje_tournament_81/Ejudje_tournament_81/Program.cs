using System;
using System.Text.RegularExpressions;

namespace A01
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"a+b{2,}c+";
            string target = "QQQ";

            string str = Console.ReadLine();
            while (str != null)
            {
                string newString = Regex.Replace(str, pattern, target);
                Console.WriteLine(newString);
                str = Console.ReadLine();
            }
            
        }
    }
}
