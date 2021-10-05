using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public partial class MyMatrix
    {
        private double precalculatedDeterminant = double.NaN;

        public static MyMatrix operator +(MyMatrix obj1, MyMatrix obj2)
        {
            if (obj1.Height != obj2.Height || obj1.Width != obj2.Width)
            {
                throw new Exception("The size of the matrices must be the same");
            }

            double[,] matrix = new double[obj1.Height, obj1.Width];

            for (int i = 0; i < obj1.Height; i++)
            {
                for (int j = 0; j < obj1.Width; j++)
                {
                    matrix[i, j] = obj1[i, j] + obj2[i, j];
                }
            }
            return new MyMatrix(matrix);
        }

        public static MyMatrix operator *(MyMatrix obj1, MyMatrix obj2)
        {
            if (obj1.Height != obj2.Width)
            {
                throw new Exception("The width and height of the matrices must be the same");
            }

            double[,] matrix = new double[obj1.Height, obj1.Width];
            int size = obj1.Height * obj1.Width;

            int k = 0;
            int additionalIndex = 0;
            for (int i = 0; i < size; i++)
            {
                if ((i % obj1.Width == 0) && (size-1 != i) && i != 0) additionalIndex++;
                if (k == obj1.Width) k = 0;
                double tempElement = 0;
                for (int j = 0; j < obj1.Width; j++)
                {
                    tempElement += obj1[additionalIndex, j] * obj2[j, k];
                }
                matrix[additionalIndex, k] = tempElement;
                k++;
            }

            return new MyMatrix(matrix);
        }

        private double[,] GetTransponedArray()
        {
            double[,] matrix = new double[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    matrix[i,j] = this.matrix[j, i];
                }
            }

            return matrix;
        }

        public MyMatrix GetTransponedCopy()
        {
            return new MyMatrix(GetTransponedArray());
        }

        public void TransponeMe()
        {
            matrix = GetTransponedArray();
        }

        private MyMatrix CreateMatrixWithoutColumn(int column)
        {
            if (column < 0 || column >= this.Width)
            {
                throw new ArgumentException("invalid column index");
            }

            var result = new MyMatrix(this.Height, this.Width - 1);

            for (var i = 0; i < result.Height; i++)
            {
                for (var j = 0; j < result.Width; j++)
                {
                    result[i, j] = j < column ? matrix[i, j] : matrix[i, j + 1];
                }
            }

            return result;
        }



        private MyMatrix CreateMatrixWithoutRow(int row)
        {
            if (row < 0 || row >= this.Height)
            {
                throw new ArgumentException("invalid row index");
            }

            var result = new MyMatrix(this.Height - 1, this.Width);

            for (var i = 0; i < result.Height; i++)
            {
                for (var j = 0; j < result.Width; j++)
                {
                    result[i, j] = i < row ? matrix[i, j] : matrix[i + 1, j];
                }
            }

            return result;
        }

        public double CalcDeterminant()
        {

            if (Height != Width)
            {
                throw new Exception("The width and height of the matrices must be the same");
            }

            if (!double.IsNaN(this.precalculatedDeterminant))
            {
                return this.precalculatedDeterminant;
            }

            if (this.Height == 2)
            {
                return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];
            }

            double result = 0;

            for (var j = 0; j < this.Width; j++)
            {
                result += (j % 2 == 1 ? 1 : -1) * this[1, j] *
                    this.CreateMatrixWithoutColumn(j).CreateMatrixWithoutRow(1).CalcDeterminant();
            }
            return result;
        }
    }
}
