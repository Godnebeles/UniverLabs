using System;
using System.Collections.Generic;
using System.Drawing;

namespace MazeRenderWF
{
    public class WithTimerRenderer
    {
        private int[,] _markedGraph;
        private Queue<Point> _nextSteps = new Queue<Point>();
        private Graphics _graphics;

        public WithTimerRenderer(int[,] markedGraph, Queue<Point> nextSteps, Graphics graphics)
        {
            _markedGraph = markedGraph;
            _nextSteps = nextSteps;
            _graphics = graphics;
        }

        public bool MakeStep()
        {
            Font font = new Font("Arial", 18);
            Brush brush = Brushes.Red;

            while (_nextSteps.Count != 0)
            {
                Point currentNode = _nextSteps.Peek();

                _nextSteps.Dequeue();

                _graphics.DrawString(
                                     Convert.ToString(_markedGraph[currentNode.X, currentNode.Y]),
                                     font, brush,
                                     currentNode.Y * 50, currentNode.X * 50, new StringFormat()
                                    );

                return false;
            }

            return true;

        }

    }
}
