using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
        private Point[] _shortestPath;
        private Queue<Point> _nextSteps;
        private int[,] _markedGraph;
        private Graphics _graphics;
        private PictureBox _pictureBox;
        private Graph _graph;
        private Font _font = new Font("Arial", 18);
        private Brush _brushForMarkers = Brushes.Green;
        private Brush _brushForShortestPath = Brushes.Red;

        public WithTimerRenderer(PictureBox pictureBox, Graphics graphics, Graph graph)
        {
            _pictureBox = pictureBox;
            _graphics = graphics;
            _graph = graph;
            _markedGraph = _graph.Bfs();
            _nextSteps = _graph.GetPathesForRenderer();
            _shortestPath = _graph.GetShortestPath();
        }

        public void ShowWalls()
        {
            for (int i = 0; i < _markedGraph.GetLength(0); i++)
            {
                for (int j = 0; j < _markedGraph.GetLength(1); j++)
                {
                    if (_markedGraph[i, j] == -1)
                        _graphics.FillRectangle(Brushes.Black, j * 50, i * 50, 50, 50);
                }
            }
        }

        public bool ShowPathLengths()
        {               
            while (_nextSteps.Count != 0)
            {
                Point currentNode = _nextSteps.Peek();

                _nextSteps.Dequeue();

                _graphics.DrawString(
                                     Convert.ToString(_markedGraph[currentNode.X, currentNode.Y]),
                                     _font, _brushForMarkers,
                                     currentNode.Y * 50, currentNode.X * 50, new StringFormat()
                                    );          
                return false;
            }

            return true;
        }


        public void ShowShortestPath()
        {
            for (int i = 0; i < _shortestPath.Length; i++)
            {
                _graphics.DrawString(
                                    Convert.ToString(_markedGraph[_shortestPath[i].X, _shortestPath[i].Y]),
                                    _font, _brushForMarkers,
                                    _shortestPath[i].Y * 50, _shortestPath[i].X * 50, new StringFormat()
                                   );
            }
        }

    }
}
