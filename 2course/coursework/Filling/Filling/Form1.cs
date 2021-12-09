using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cursach_reborn
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Color colorForFiling = Color.YellowGreen;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        public Point[] GetNearestElements(Point node)//Метод отримує 4 точки навколо пікселя на якого натиснули
        {
            Point[] points = new Point[4];

            points[0] = new Point(node.X, node.Y + 1);
            points[1] = new Point(node.X, node.Y - 1);
            points[2] = new Point(node.X + 1, node.Y);
            points[3] = new Point(node.X - 1, node.Y);

            return points;
        }

        private bool CoordinateIsCorrect(Bitmap bm, Point point)//Перевірка розміру картинки 
        {
            return (point.X >= 0 &&
                    point.X < bm.Width &&
                    point.Y >= 0 &&
                    point.Y < bm.Height);
        }

        private bool ColorIsCorrectForFilling(Color foundPixel, Color newColor, Color oldColor)
        {
            return foundPixel.ToArgb() == oldColor.ToArgb() && foundPixel.ToArgb() != newColor.ToArgb();
        }

        private bool ColorIsSame(Color color1, Color color2)// перевірка на однаковість кольорів(Чи потрібно перевіряти канал А(прозорість)???)
        {
            return color1.ToArgb() == color2.ToArgb();
        }

        public Bitmap FillArea(Point start, Color oldColor, Color newColor)
        {
            Bitmap image = (Bitmap)bitmap.Clone();
            Stack<Point> stack = new Stack<Point>();

            stack.Push(start);

            Point currentNode;

            while (stack.Count != 0)
            {
                currentNode = stack.Pop();

                image.SetPixel(currentNode.X, currentNode.Y, newColor);

                Point[] points = GetNearestElements(currentNode);

                for (int i = 0; i < points.Length; i++)
                {
                    if (CoordinateIsCorrect(image, points[i]))
                    {
                        Color foundPixel = image.GetPixel(points[i].X, points[i].Y);

                        if (ColorIsCorrectForFilling(foundPixel, newColor, oldColor))
                        {
                            stack.Push(points[i]);
                        }
                    }

                }
            }

            return image;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pressedPoint = new Point(e.X, e.Y);

            Color pressedColor = bitmap.GetPixel(pressedPoint.X, pressedPoint.Y);

            if (!ColorIsSame(colorForFiling, pressedColor))
            {
                bitmap = FillArea(pressedPoint, pressedColor, colorForFiling);

                pictureBox1.Image = bitmap;
            }
        }
    }
}
