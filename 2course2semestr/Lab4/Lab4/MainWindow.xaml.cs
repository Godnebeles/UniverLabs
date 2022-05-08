using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;


namespace Lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    //public class Point
    //{
    //    public int X { get; private set; }
    //    public int Y { get; private set; }

    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //}

    public partial class MainWindow : Window
    {
        Point currentPoint = new Point();

        private List<Point> _points;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int count = 5;
            GeneratePoint(count);
            DrawPoints(_points);
        }


        public void GeneratePoint(int count)
        {
            _points = new List<Point>();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                _points.Add(new Point(
                                    random.Next(0, Convert.ToInt32(MainCanvas.ActualWidth)), 
                                    random.Next(0, Convert.ToInt32(MainCanvas.ActualHeight))
                                    ));
            }
        }

        public void DrawPoints(List<Point> points)
        {
            foreach (var point in points)
            {
                Ellipse ellipse = new Ellipse();

                ellipse.Fill = new SolidColorBrush(Colors.Red);
                //ellipse.Stroke = new SolidColorBrush(Colors.Red);
                ellipse.Width = 5;
                ellipse.Height = 5;
                ellipse.SetValue(Canvas.TopProperty, point.Y);
                ellipse.SetValue(Canvas.LeftProperty, point.X);
               

                MainCanvas.Children.Add(ellipse);

            }
        }

        private void DrawPolygons(List<Point> points)
        {
            
        }

        private void Canvas_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(this);
        }

        private void Canvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;

                currentPoint = e.GetPosition(this);

                MainCanvas.Children.Add(line);
               
            }
        }

        
    }
}
