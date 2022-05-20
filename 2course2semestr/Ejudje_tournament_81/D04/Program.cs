using System;
using System.Text.RegularExpressions;

namespace D04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "\\$v_{(?<name>(\\w*))}\\$";
            string target = "v[${name}]";

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
