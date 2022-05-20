using System;
using System.Text.RegularExpressions;

namespace E05
{
    public class Program
    {
        static void Main(string[] args)
        {
            string pattern = "\\$v_(({(?<name>[\\dA-Za-z]*)})|((?<name>[\\dA-Za-z])))\\$";
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
