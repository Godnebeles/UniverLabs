using System;
using System.Text.RegularExpressions;

namespace H08
{
    internal class Program
    {
        //  \circle{(480,10),2}
        static void Main(string[] args)
        {
            string pattern = @"\\circle{\((?<x>[0-9]+),(?<y>[0-9]+)\)";
            string target = "\\circle{(${y},${x})";

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
