using Lab1_Block1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Block1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            AriphmeticProgression ap = new AriphmeticProgression(3, 6);
            ap.PrintAriphmeticProgression(100);

            Console.WriteLine("Введіть індекс числа, яке хочете получити");
            int v = int.Parse(Console.ReadLine());

            Console.WriteLine(ap[v - 1]);

            Console.WriteLine("Введіть кількість елементів суму яких хочете получити");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(ap.Sum(b));

            Console.ReadKey();
        }
    }
}