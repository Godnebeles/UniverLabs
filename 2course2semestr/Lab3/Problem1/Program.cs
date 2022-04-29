using System;

namespace Problem1
{
    public delegate double CalculateFunction(double x);
    public class Program
    {

        static void Main(string[] args)
        {
            CalculateFunction[] calculateFunctions = { 
                                                       (x) => Math.Sqrt(Math.Abs(x)),
                                                       (x) => Math.Pow(x, 3),
                                                       (x) => x + 3.5
                                                      };

            while (true)
            {
                try
                {
                    Console.WriteLine("Вводьте рядки послідовно один за одним.");
                    Console.WriteLine("Поки вони матимуть вигляд 1 х чи 2 х чи 3 х");
                    Console.WriteLine("(тобто, цифра від 0 до 2, а після неї запис конкретного дійсного числа),");
                    Console.WriteLine("програма обчислюватиме одну з трьох функцій:");
                    Console.WriteLine("\t\t0 - sqrt(abs(x))");
                    Console.WriteLine("\t\t1 - x^3");
                    Console.WriteLine("\t\t2 - x + 3.5");
                    Console.WriteLine("Згідно цифри на початку виводитиме результат.");
                    Console.WriteLine("Якщо вхідний рядок не задовольний цей результат, програма завершить свою роботу.");
                    Console.Write("Ваша відповідь: ");

                    string[] answer = Console.ReadLine().Split();

                    Console.WriteLine(calculateFunctions[Convert.ToInt32(answer[0])](Convert.ToInt32(answer[1])));
                }
                catch (Exception)
                {                  
                    Console.WriteLine("Goodbye, Nigga!");
                    break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
