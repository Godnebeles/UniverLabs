using System;
using System.Text.RegularExpressions;

namespace B02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>[a-z][A-Z])";
            string target = "_?_${name}_?_";

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
