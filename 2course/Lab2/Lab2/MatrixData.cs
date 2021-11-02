using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public partial class MyMatrix
    {
        private double[,] matrix;
        public int Height { get { return matrix.GetLength(0);  } }
        public int Width { get { return matrix.GetLength(1);  } }

        public MyMatrix(int i, int j)
        {
            matrix = new double[i, j];
            //Height = matrix.GetLength(0);
            //Width = matrix.GetLength(1);
        }

        public MyMatrix(MyMatrix obj)
        {
            matrix = (double[,])obj.matrix.Clone();
            //Height = matrix.GetLength(0);
            //Width = matrix.GetLength(1);
        }

        public MyMatrix(double[,] matrix)
        {
            this.matrix = (double[,])matrix.Clone();
            //Height = matrix.GetLength(0);
            //Width = matrix.GetLength(1);

        }

        public MyMatrix(double[][] matrix)
        {

            //Height = matrix.Length;
            //Width = matrix[0].Length;
            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i].Length != matrix[0].Length) throw new Exception("Matrix must be rectangular");
            }
            this.matrix = new double[matrix.Length, matrix[0].Length];

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    this.matrix[i, j] = matrix[i][j];
                }
            }
        }

        public MyMatrix(string[] matrix)
        {
            this.matrix = GetMatrixFromArrayString(matrix);
        }

        public MyMatrix(string matrix)
        {
            string[] rows = matrix.Split('\n');
            this.matrix = GetMatrixFromArrayString(rows);
        }

        private double[,] GetMatrixFromArrayString(string[] rows)
        {
            int height = rows.Length;
            int width = rows[0].Split(new char[] { ' ', '\t', ':' }, StringSplitOptions.RemoveEmptyEntries).Length;
            for (int i = 1; i < height; i++)
            {
                string[] elems = rows[i].Split(new char[] { ' ', '\t', ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (elems.Length != width)
                {
                    if (elems.Length == 0)
                    {
                        height--;
                        continue;
                    }
                    throw new Exception("Matrix must be rectangular");
                }
            }

            double[,] matrix = new double[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = Convert.ToDouble(rows[i].Split(new char[] { ' ', '\t', ':' }, StringSplitOptions.RemoveEmptyEntries)[j]);
                }
            }

            return matrix;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }

        public double GetElemMatrix(int i, int j)
        {
            if (
                 (i >= 0 && i < matrix.GetLength(0)) &&
                 (j >= 0 && j < matrix.GetLength(1))
               )
            {
                return matrix[i, j];
            }
            else
            {
                throw new Exception("Incorrect index");
            }
        }

        public void SetElemMatrix(int i, int j, double elem)
        {
            if (
                 (i >= 0 && i < matrix.GetLength(0)) &&
                 (j >= 0 && j < matrix.GetLength(1))
               )
            {
                matrix[i, j] = elem;
                precalculatedDeterminant = double.NaN;
            }
            else
            {
                throw new Exception("Incorrect index");
            }
        }

        public double this[int i, int j]
        {
            get
            {
                if (
                    (i >= 0 && i < matrix.GetLength(0)) &&
                    (j >= 0 && j < matrix.GetLength(1))
                   )
                {
                    return matrix[i, j];
                }
                else
                {
                    throw new Exception("Incorrect index");
                }
            }
            set
            {
                if (
                    (i >= 0 && i < matrix.GetLength(0)) &&
                    (j >= 0 && j < matrix.GetLength(1))
                   )
                {
                    matrix[i, j] = value;
                    this.precalculatedDeterminant = double.NaN;
                }
                else
                {
                    throw new Exception("Incorrect index");
                }
            }
        }

        private string GetMatrixToSting()
        {
            string matrixString = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrixString += matrix[i, j] + "\t";
                }
                matrixString += "\n";
            }
            return matrixString;
        }

        public override string ToString()
        {
            return GetMatrixToSting();
        }
    }
}
