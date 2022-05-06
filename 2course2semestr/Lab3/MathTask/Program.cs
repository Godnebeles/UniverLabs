using System;

namespace MathTask
{
    public delegate double MathFunction(int i);

    public class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            Console.WriteLine(Calculate(InfiniteSeries1, number));
            Console.WriteLine(Calculate(InfiniteSeries2, number));
            Console.WriteLine(Calculate(InfiniteSeries3, number));
        }

        private static double Calculate(MathFunction mathFunction, int count)
        {
            int iterator = 0;
            double result = 0;
            do
            {
                result += mathFunction(iterator);
                iterator++;
            } while (iterator < count);
            return result;
        }

        private static double InfiniteSeries1(int f)
        {
            return 1 / Math.Pow(2, f);
        }

        private static double InfiniteSeries2(int f)
        {
            double result = Factorial(f+1);
            return 1 / result;
        }

        private static double Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }

        private static double InfiniteSeries3(int f)
        {
            return f % 2 == 0 && f != 0 ? (1 / Math.Pow(2, f)) * -1.0 : 1 / Math.Pow(2, f);
        }
    }
}
