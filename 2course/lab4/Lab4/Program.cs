using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFrac[] arr = FillArray();
            testSort(arr);

            testSquaresDifference(new MyFrac(1, 3), new MyFrac(1, 6));
            testSquaresDifference(new MyComplex(1, 3), new MyComplex(1, 6));
            Console.WriteLine();
            testAPlusBSquare(new MyFrac(1, 3), new MyFrac(1, 6));
            testAPlusBSquare(new MyComplex(1, 3), new MyComplex(1, 6));
            Console.ReadKey();
        }

        static void Print<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void testSort<T>(T[] a) where T : IMyNumber<T>, IComparable<T>
        {
            Print(a);
            Array.Sort(a);
            Print(a);
        }

        static MyFrac[] FillArray()
        {
            MyFrac[] arr = new MyFrac[5];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new MyFrac(rand.Next(-5, 5), rand.Next(-5, 5));
            }

            return arr;
        }

        static void testSquaresDifference<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a-b)=a^2-b^2/a+b with a = " + a + ", b = " + b + " ===");
            T aSubtractB = a.Substract(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a - b) = " + aSubtractB);
            Console.WriteLine(" = = = ");
            T currA = a.Multiply(a);
            Console.WriteLine("a^2 = " + currA);
            T currB = b.Multiply(b);
            Console.WriteLine("b^2 = " + currB);
            T nom = currA.Substract(currB);
            Console.WriteLine("a^2 - b^2 = " + nom);
            T denom = a.Add(b);
            Console.WriteLine("a + b = " + denom);
            T rightPart = nom.Divide(denom);
            Console.WriteLine("a^2-b^2/a+b = " + rightPart);
            Console.WriteLine("=== Finishing testing (a-b)=a^2-b^2/a+b with a = " + a + ", b = " + b + " ===");
        }

        static void testAPlusBSquare<T>(T a, T b) where T : IMyNumber<T>
        {
            Console.WriteLine("=== Starting testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
            T aPlusB = a.Add(b);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("(a + b) = " + aPlusB);
            Console.WriteLine("(a+b)^2 = " + aPlusB.Multiply(aPlusB));
            Console.WriteLine(" = = = ");
            T curr = a.Multiply(a);
            Console.WriteLine("a^2 = " + curr);
            T wholeRightPart = curr;
            curr = a.Multiply(b);
            curr = curr.Add(curr); 

            Console.WriteLine("2*a*b = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            curr = b.Multiply(b);
            Console.WriteLine("b^2 = " + curr);
            wholeRightPart = wholeRightPart.Add(curr);
            Console.WriteLine("a^2+2ab+b^2 = " + wholeRightPart);
            Console.WriteLine("=== Finishing testing (a+b)^2=a^2+2ab+b^2 with a = " + a + ", b = " + b + " ===");
        }
    }
}
