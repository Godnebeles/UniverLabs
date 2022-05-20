using System;
using System.Text.RegularExpressions;

namespace F06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\\texttt{(?<innerText>([a-zA-Z]+|\d+))}";
            string target = "\\begin{ttfamily}${innerText}\\end{ttfamily}";

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
