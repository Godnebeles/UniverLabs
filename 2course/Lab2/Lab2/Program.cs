using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //double[,] arr = new double[2,3];
            //double[][] arrJagged = new double[5][];
            //for (int i = 0; i < arrJagged.Length; i++)
            //{

            //    arrJagged[i] = new double[7];
            //}
            //for (int i = 0; i < arrJagged.Length; i++)
            //{
            //    for (int j = 0; j < arrJagged[0].Length; j++)
            //    {

            //        arrJagged[i][j] = value.Next() % 25;
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = value.Next() % 25;
            //    }
            //}

            //MyMatrix matrixFromString = new MyMatrix(arrString);
            //MyMatrix matrixFromJaggedArray = new MyMatrix(arrJagged);
            //MyMatrix matrixFromCommonArray = new MyMatrix(arr);
            //MyMatrix matrixFromObjectString = new MyMatrix(matrixFromString);

            //Console.WriteLine("matrixFromString\n" + matrixFromString);
            //Console.WriteLine("matrixFromJaggedArray\n" + matrixFromJaggedArray);
            //Console.WriteLine("matrixFromCommonArray\n" + matrixFromCommonArray);
            //Console.WriteLine("matrixFromObjectString\n" + matrixFromObjectString);

            //Console.WriteLine("Multiply matrixes\n" + matrixFromString * matrixFromObjectString);
            //Console.WriteLine($"Add matrixes\n{matrixFromString + matrixFromObjectString}");

            //matrixFromString.TransponeMe(); // 4x4 matrix
            //Console.WriteLine("Transposed matrix 'matrixFromString'\n" + matrixFromString);

            //Console.WriteLine("Determined matrix's: " + matrixFromObjectString.CalcDeterminant());

            //Console.WriteLine($"Before Transpose\n{matrixFromCommonArray}");
            //Console.WriteLine($"height: {matrixFromCommonArray.Height}, width: {matrixFromCommonArray.Width}");
            //matrixFromCommonArray.TransponeMe(); // 2x3 matrix
            //Console.WriteLine($"Transpose\n{matrixFromCommonArray}");
            //Console.WriteLine($"height: {matrixFromCommonArray.Height}, width: {matrixFromCommonArray.Width}");
            //string testMatrixToString = matrixFromCommonArray.ToString();

            //MyMatrix test1 = new MyMatrix(testMatrixToString);
            //Console.WriteLine(test1);

            Random value = new Random();
            string stringArr = "1\t2\t3 4\n4 5 6 6\n7 8 12 33\n8 9 3 42";
            MyMatrix matrix = new MyMatrix(stringArr);
            Console.WriteLine("Determinant: " + matrix.CalcDeterminant());

            Console.ReadLine();
        }
    }
}
