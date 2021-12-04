using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach_reborn
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Bitmap bitmap;
        private Color[,] matrix;

        public Form1()
        {
            InitializeComponent();

            matrix = new Color[pictureBox1.Width, pictureBox1.Height];
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
        }


        public void InitializeForFilling()
        {
            matrix = new Color[bitmap.Width, bitmap.Height];
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    matrix[i, j] = bitmap.GetPixel(i, j);

                    //graphics.FillRectangle(Brushes.Black, j, i, 1, 1);
                }
            }
        }


        public void Draw()
        {

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Brush brush = new SolidBrush(matrix[i, j]);
                    graphics.FillRectangle(brush, i, j, 1, 1);
                }
            }

            pictureBox1.Image = bitmap;
        }


        public Point[] GetNearestElements(Point node)
        {
            Point[] points = new Point[8];

            points[0] = new Point(node.X, node.Y - 1);
            points[1] = new Point(node.X, node.Y + 1);
            points[2] = new Point(node.X - 1, node.Y);
            points[3] = new Point(node.X + 1, node.Y);

            points[4] = new Point(node.X + 1, node.Y + 1);
            points[5] = new Point(node.X - 1, node.Y - 1);
            points[6] = new Point(node.X + 1, node.Y - 1);
            points[7] = new Point(node.X - 1, node.Y + 1);

            return points;
        }


        private bool CoordinateIsCorrect(Point point, Color oldColor)
        {
            if (point.X >= 0 &&
                point.X < bitmap.Width &&
                point.Y >= 0 &&
                point.Y < bitmap.Height)
            {
                Color colorNewPixel = matrix[point.X, point.Y];
                int[] colorNewPixelInArgb = new int[3] { colorNewPixel.R, colorNewPixel.G, colorNewPixel.B };
                int[] colorOldPixelInArgb = new int[3] { oldColor.R, oldColor.G, oldColor.B };

                if (colorNewPixelInArgb[0] == colorOldPixelInArgb[0] &&
                    colorNewPixelInArgb[1] == colorOldPixelInArgb[1] &&
                    colorNewPixelInArgb[2] == colorOldPixelInArgb[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }


        public void FillArea(Point start, Color oldColor, Color newColor)
        {
            Queue<Point> queue = new Queue<Point>();

            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                Point currentNode = queue.Peek();

                queue.Dequeue();

                Point[] points = GetNearestElements(currentNode);

                for (int i = 0; i < points.Length; i++)
                {
                    if (CoordinateIsCorrect(points[i], oldColor))
                    {
                        matrix[points[i].X, points[i].Y] = newColor;
                        queue.Enqueue(points[i]);
                    }
                }
            }
        }


        public void RecursiveFill(Point start, Color oldColor, Color newColor)
        {
            if (!CoordinateIsCorrect(start, oldColor))
                return;

            graphics.FillRectangle(Brushes.Black, start.X, start.Y, 1, 1);

            RecursiveFill(new Point(start.X, start.Y + 1), oldColor, newColor);
            RecursiveFill(new Point(start.X, start.Y - 1), oldColor, newColor);
            RecursiveFill(new Point(start.X - 1, start.Y), oldColor, newColor);
            RecursiveFill(new Point(start.X + 1, start.Y), oldColor, newColor);

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);
                graphics = Graphics.FromImage(bitmap);
                InitializeForFilling();
                pictureBox1.Image = bitmap;
            }
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int cursorX = e.X;
            int cursorY = e.Y;

            Color oldColor = bitmap.GetPixel(e.X, e.Y);


            FillArea(new Point(cursorX, cursorY), oldColor, Color.Red);

            Draw();
            //RecursiveFill(new Point(cursorX, cursorY), oldColor, Color.Red);

            ////graphics.FillRectangle(Brushes.Black, cursorX, cursorY, 20, 20);

            //pictureBox1.Image = bitmap;
        }
    }
}
