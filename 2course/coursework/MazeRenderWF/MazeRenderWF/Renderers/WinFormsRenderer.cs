using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeRenderWF
{
    public class WinFormsRenderer
    {
        private PictureBox _pictureBox;
        private Bitmap _bm;
        private Graphics _graphics;

        public WinFormsRenderer(Bitmap bm, PictureBox pictureBox)
        {
            _bm = bm;
            _pictureBox = pictureBox;
            _graphics = Graphics.FromImage(_bm);
        }


        public void ShowWalls(int[,] matrix, List<Point> exits)
        {
            Graphics graphics = Graphics.FromImage(_bm);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == -1)
                        graphics.FillRectangle(Brushes.Black, j * 50, i * 50, 50, 50);
                }
            }

            _pictureBox.Image = _bm;
        }

        public void ShowElement(Point point, int value)
        {
            Font font = new Font("Arial", 18);
            Brush brush = Brushes.Black;


            if (!(point.X == 0 || point.Y == 0 || point.X == 9 || point.Y == 9))
            {
                _graphics.DrawString(Convert.ToString(value),
                                    font, brush,
                                    point.Y * 50, point.X * 50, new StringFormat());
                _pictureBox.Image = _bm;
            }
        }

        public void ShowPathLengths(int[,] matrix)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(ShowPathLengthsThread));
            thread.Start(matrix);
        }

        private void ShowPathLengthsThread(object param)
        {
            var matrix = (int[,])param;
            Font font = new Font("Arial", 18);
            Brush brush = Brushes.Black;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!(i == 0 || j == 0 || i == 9 || j == 9 || matrix[i, j] == -1))
                    {
                        _graphics.DrawString(Convert.ToString(matrix[i, j]),
                                            font, brush,
                                            j * 50, i * 50, new StringFormat());
                        Thread.Sleep(1000);
                    }
                    _pictureBox.Image = _bm;
                }
            }

        }

    }
}
