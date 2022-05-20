using System;
using System.Text.RegularExpressions;

namespace G07
{
    internal class Program
    {
        static void Main(string[] args)
        { // Adss Add Aaa Add
            string pattern = @"(?<words>[A-Z][a-zA-Z]*(\s+[A-Z][a-zA-Z]*){2,})";
            string target = "\"${words}\"";

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
