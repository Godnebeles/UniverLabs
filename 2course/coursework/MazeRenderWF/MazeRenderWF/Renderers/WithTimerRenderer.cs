using System;
using System.Collections.Generic;
using System.Drawing;

/*
1) рендерим стены
2) выводим ратояние каждой клетки
3) Красим самый короткий путь

Structs: 
 
    1) bool ShowPathLengths


 */

namespace MazeRenderWF
{
    public class WithTimerRenderer
    {
        private Graphics _graphics;
        private Graph _graph;
        private Font _font = new Font("Arial", 18);
        private Brush _brushForMarkers = Brushes.Green;
        private Brush _brushForShortestPath = Brushes.Red;

        public WithTimerRenderer(Graphics graphics, Graph graph)
        {
            _graphics = graphics;
            _graph = graph;
        }

        public bool ShowPathLengths()
        {
            Queue<Point> nextSteps = _graph.GetPathesForRenderer();
            int[,] markedGraph = _graph.Bfs();

            while (nextSteps.Count != 0)
            {
                Point currentNode = nextSteps.Peek();

                nextSteps.Dequeue();

                _graphics.DrawString(
                                     Convert.ToString(markedGraph[currentNode.X, currentNode.Y]),
                                     _font, _brushForMarkers,
                                     currentNode.Y * 50, currentNode.X * 50, new StringFormat()
                                    );

                return false;
            }

            return true;
        }

        public void ShowShortestPath()
        {
            Point[] shortestPath = _graph.GetShortestPath();
        }

    }
}
