using System;
using System.Text.RegularExpressions;

namespace C03
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pattern = "\\$v_(?<name>([0-9]|[a-z]|[A-Z]))\\$";
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
