using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {

        static void Main(string[] args)
        {

            int countGraphs = int.Parse(Console.ReadLine());

            for (int i = 0; i < countGraphs; i++)
            {
                string[] sizeGraph = Console.ReadLine().Split();
                int countVertexes = int.Parse(sizeGraph[0]);
                int countEdges = int.Parse(sizeGraph[1]);
                var graph = new Graph(countVertexes);
                List<Vertex> myVertexes = new List<Vertex>();

                for (int t = 0; t < countVertexes; t++)
                {
                    Vertex tempVertex = new Vertex(t);
                    graph.AddVertex(tempVertex);
                    myVertexes.Add(tempVertex);
                }

                for (int j = 0; j < countEdges; j++)
                {
                    string[] fromTo = Console.ReadLine().Split();

                    var edge = new Edge(myVertexes[int.Parse(fromTo[0])], myVertexes[int.Parse(fromTo[1])]);

                    graph.AddEdge(edge);
                }

                int startWave = int.Parse(Console.ReadLine().Trim());

                for (int k = 0; k < countVertexes; k++)
                {
                    if (k == startWave)
                        Console.Write(0 + " ");
                    else
                    {

                        //bool waves = graph.BreadthFirstSearch(myVertexes[startWave], myVertexes[k]);
                        //List<Vertex> waves = graph.BreadthFirstSearch(myVertexes[startWave], myVertexes[k]);
                        //Console.Write(waves);
                        //foreach(var item in waves)
                        //{
                        //    Console.Write(item.Number + " ");
                        //}
                        //Console.WriteLine();
                        //if (waves.Count == 1)
                        //{
                        //    Console.Write(987654321 + " ");
                        //}
                        //else
                        //{
                        //    Console.Write(waves.Count - 1 + " ");
                        //}


                        int wave = graph.Test(myVertexes[startWave], myVertexes[k]);
                        if (wave == 0)
                        {
                            Console.Write(987654321 + " ");
                        }
                        else
                        {
                            Console.Write(wave + " ");
                        }
                    }
                }

                Console.WriteLine();

            }
        }

        public class Graph
        {
            private List<Vertex> Vertexes = new List<Vertex>();
            private List<Edge> Edges = new List<Edge>();
            public int VertexCount { get { return Vertexes.Count; } }
            public bool IsOriented { get; set; }

            public int[,] GetAdjacencyMatrix()
            {
                int[,] matrix = new int[Vertexes.Count, Vertexes.Count];

                foreach (var edge in Edges)
                {
                    var row = edge.From.Number;
                    var col = edge.To.Number;

                    matrix[row, col] = edge.Weight;
                }

                return matrix;
            }

            public List<Vertex> GetAdjacencyVertexes(Vertex vertex)
            {
                List<Vertex> adjancencyVertexes = new List<Vertex>();

                foreach (var edge in Edges)
                {
                    if (edge.From == vertex)
                    {
                        adjancencyVertexes.Add(edge.To);
                    }
                }

                return adjancencyVertexes;
            }

            public List<Edge> GetAdjacencyEdges(Vertex from, Vertex to)
            {
                List<Edge> adjancencyEdges = null;

                foreach (var edge in Edges)
                {
                    if (edge.From == from && edge.To == to)
                    {
                        adjancencyEdges.Add(edge);
                    }
                }

                return adjancencyEdges;
            }

            public int Test(Vertex from, Vertex to)
            {
                int count = 0;
                Vertex current = null;
                if (!BreadthFirstSearch(from, to))
                    return 0;

                int[,] matrix = GetAdjacencyMatrix();

                for (int i = 0; i < Edges.Count; i++)
                {
                    if (current == to)
                    {
                        return count;
                    }
                    if (from.Number == i)
                        continue;
                    else
                    {
                        if (IsStraightDirection(from, to))
                            return count + 1;

                        List<Vertex> curVertexes = GetAdjacencyVertexes(from);
                        current = null;
                        foreach (var item in curVertexes)
                        {

                            if (IsStraightDirection(current, to))
                                return count + 1;

                            if (BreadthFirstSearch(item, to))
                            {
                                if (matrix[from.Number, item.Number] > 1)
                                {
                                    count--;
                                    continue;
                                }
                                   
                                current = item;
                                if (curVertexes.Count > 1)
                                    matrix[from.Number, item.Number] += 1;
                                break;
                            }


                        }

                        if (current != null)
                        {
                            count++;
                            from = current;
                        }
                        else
                        {
                            return count;
                        }
                        
                    }

                }

                return count;
            }

            private bool IsStraightDirection(Vertex start, Vertex end)
            {
                foreach (var item in Edges)
                {
                    if (item.From == start && item.To == end)
                        return true;
                }
                return false;
            }

            public bool BreadthFirstSearch(Vertex first, Vertex last)
            {
                List<Vertex> wave = new List<Vertex>();
                wave.Add(first);
                int counter = 0;
                //if (first.Number == last.Number)
                //    return wave;
                for (int i = 0; i < wave.Count; i++)
                {
                    Vertex vertex = wave[i];

                    foreach (var curVertext in GetAdjacencyVertexes(vertex))
                    {

                        if (!wave.Contains(curVertext))
                        {
                            wave.Add(curVertext);
                            counter++;
                        }
                        //if (curVertext.Number == last.Number)
                        //    return wave;
                    }
                }

                return wave.Contains(last);
            }

            public List<Edge> EdgesFromTo(Vertex first, Vertex last)
            {
                List<Vertex> wave = new List<Vertex>();
                List<Edge> edgesToWave = new List<Edge>();
                wave.Add(first);

                for (int i = 0; i < wave.Count; i++)
                {
                    Vertex vertex = wave[i];

                    foreach (var curVertext in GetAdjacencyVertexes(vertex))
                    {
                        if (!wave.Contains(curVertext))
                        {
                            wave.Add(curVertext);
                        }
                    }
                }



                return edgesToWave;

            }



            public Graph(int countVertexes)
            {
                SetAnyCountVertexes(countVertexes);
            }

            public void SetAnyCountVertexes(int count)
            {
                for (int i = 0; i < count; i++)
                {
                    Vertexes.Add(new Vertex(i));
                }
            }

            public void AddEdge(Edge edge)
            {
                Edges.Add(edge);
            }

            public void AddVertex(Vertex vertex)
            {
                Vertexes.Add(vertex);
            }


        }

        public class Vertex
        {
            public int Number { get; set; }
            public Vertex(int number)
            {
                Number = number;
            }
        }

        public class Edge
        {
            public Vertex From { get; set; }
            public Vertex To { get; set; }
            public int Weight { get; set; }

            public Edge(Vertex from, Vertex to, int weight = 1)
            {
                From = from;
                To = to;
                Weight = weight;
            }
        }


    }
}
