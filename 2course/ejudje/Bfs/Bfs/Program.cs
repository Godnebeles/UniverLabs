using System;
using System.Collections.Generic;
using System.IO;

namespace Bfs
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEjudje();
        }

        public static void ForEjudje()
        {
            Graph graph = new Graph();

            StreamWriter output = new StreamWriter("output.txt", false);
            using (StreamReader input = new StreamReader("input.txt"))
            {
                int graphCount = int.Parse(input.ReadLine());
                for (int i = 0; i < graphCount; i++)
                {
                    graph.CreateFromFile(input);

                    int start = int.Parse(input.ReadLine());

                    graph.PrintPathesFromToInFile(output, start);
                }
                output.Close();
            }
        }

        public class Graph
        {
            private List<int>[] graph;

            private int vertexesCount = 0;
            private int edgesCount = 0;
           
            private void InitialGraph()
            {
                graph = new List<int>[edgesCount];

                for (int k = 0; k < edgesCount; k++)
                    graph[k] = new List<int>();
            }

            public void CreateFromFile(StreamReader reader)
            {

                string[] size = reader.ReadLine().Split();

                edgesCount = int.Parse(size[0]);
                vertexesCount = int.Parse(size[1]);

                InitialGraph();

                for (int j = 0; j < vertexesCount; j++)
                {
                    string[] row = reader.ReadLine().Split();

                    int firstNumber = int.Parse(row[0]);
                    int secondNumber = int.Parse(row[1]);

                    graph[firstNumber].Add(secondNumber);
                }


            }

            public int[] BfsJustAllLengthes(int start)
            {
                Queue<int> queue = new Queue<int>();
                bool[] used = new bool[edgesCount];
                int[] pathLenghtes = new int[edgesCount];

                used[start] = true;

                queue.Enqueue(start);

                while (queue.Count != 0)
                {
                    int number = queue.Peek();
                    queue.Dequeue();

                    foreach (int item in graph[number])
                    {
                        if (!used[item])
                        {
                            queue.Enqueue(item);
                            used[item] = true;
                            pathLenghtes[item] = pathLenghtes[number] + 1;
                        }
                    }
                }
                return pathLenghtes;
            }

            public void PrintPathesFromToInFile(StreamWriter writer, int start)
            {
                int[] pathLenghtes = BfsJustAllLengthes(start);

                for (int j = 0; j < pathLenghtes.Length; j++)
                {
                    if (pathLenghtes[j] == 0 && j != start)
                        writer.Write("987654321 ");
                    else
                        writer.Write(pathLenghtes[j] + " ");
                }
                writer.WriteLine();
            }
        }

    }
}
