using System.Collections.Generic;


namespace MazeRenderWF
{
    public interface IGraphRenderer
    {
        void ShowWalls(int[,] matrix, List<Point> exits);
        void ShowPathLengths(int[,] matrix);
        void ShowShortestPath();
        void ShowElement(Point point, int value);
    }

}
