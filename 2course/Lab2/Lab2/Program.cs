using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random value = new Random();
            string arrString = "1\t2\t3 4\n4 5 6 6\n7 8 12 33\n8 9 3 44";
            double[,] arr = new double[5,7];
            double[][] arrJagged = new double[5][];
            for (int i = 0; i < arrJagged.Length; i++)
            {

                arrJagged[i] = new double[7];
            }
            for (int i = 0; i < arrJagged.Length; i++)
            {
                for (int j = 0; j < arrJagged[0].Length; j++)
                {
                    
                    arrJagged[i][j] = value.Next() % 25;
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = value.Next() % 25;
                }
            }

            MyMatrix matrixFromString = new MyMatrix(arrString);
            MyMatrix matrixFromJaggedArray = new MyMatrix(arrJagged);
            MyMatrix matrixFromCommonArray = new MyMatrix(arr);
            MyMatrix matrixFromObjectString = new MyMatrix(matrixFromString);

            Console.WriteLine("matrixFromString\n" + matrixFromString);
            Console.WriteLine("matrixFromJaggedArray\n" + matrixFromJaggedArray);
            Console.WriteLine("matrixFromCommonArray\n" + matrixFromCommonArray);
            Console.WriteLine("matrixFromObjectString\n" + matrixFromObjectString);

            Console.WriteLine("Multiply matrixes\n" + matrixFromString * matrixFromObjectString);
            Console.WriteLine($"Add matrixes\n{matrixFromString + matrixFromObjectString}");

            matrixFromString.TransponeMe();
            Console.WriteLine("Transposed matrix 'matrixFromString'\n" + matrixFromString);

            Console.WriteLine("Determined matrix's: " + matrixFromObjectString.CalcDeterminant());


            string test = matrixFromCommonArray.ToString();
            
            MyMatrix test1 = new MyMatrix(test);
            Console.WriteLine(test1);

        }
    }
}
