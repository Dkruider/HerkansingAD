using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Huiswerk6
{
    public class Graph : IGraph
    {
        public static readonly double INFINITY = System.Double.MaxValue;

        private Dictionary<string, Vertex> vertexMap;


        //----------------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------------

        public Graph()
        {
            vertexMap = new Dictionary<string, Vertex>();
        }


        //----------------------------------------------------------------------
        // Interface methods that have to be implemented for exam
        //----------------------------------------------------------------------

        public Vertex GetVertex(string name)
        {
            Vertex findVertex = vertexMap.FirstOrDefault(x => x.Key == name).Value;

            if (findVertex == null) vertexMap.Add(name, new Vertex(name));

            return findVertex;
        }

        public List<Vertex> GetAllVertices()
        {
            return vertexMap.Values.ToList();
        }

        public void AddEdge(string source, string dest, double cost)
        {
            Vertex findVertex = GetVertex(source);

            findVertex.Adj.Add(new Edge(GetVertex(dest), cost));

            vertexMap[source] = findVertex;
        }

        public void ClearAll()
        {
            foreach (Vertex v in vertexMap.Values)
            {
                v.Reset();
            }
        }


        //----------------------------------------------------------------------
        // ToString that has to be implemented for exam
        //----------------------------------------------------------------------

        public override string ToString()
        {
            string printString = "";

            foreach (Vertex v in vertexMap.Values)
            {
                printString += v.Name;

                if (!v.Dist.Equals(INFINITY)) printString += "(" + v.Dist + ")";

                if (v.Adj.Count > 0)
                {
                    printString += " [ ";

                    foreach (Edge a in v.Adj)
                    {
                        printString += a.dest.Name + "(" + a.cost + ") ";
                    }

                    printString += "]";
                }

                printString += Environment.NewLine;
            }

            return printString.TrimEnd();
        }


        //----------------------------------------------------------------------
        // Interface methods : methods that have to be implemented for homework
        //----------------------------------------------------------------------

        public void Unweighted(string name)
        {
            ClearAll();

            Vertex startVertex = GetVertex(name);
            startVertex.Dist = 0;

            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                Vertex v = queue.Dequeue();

                foreach (Edge a in v.Adj)
                {
                    Vertex w = a.dest;

                    if (w.Dist == INFINITY)
                    {
                        w.Dist = v.Dist + 1;
                        w.Prev = v;
                        queue.Enqueue(w);
                    }
                }
            }
        }

        public void Dijkstra(string name)
        {
            ClearAll();

            List<Vertex> vertices = new List<Vertex>();

            Vertex startVertex = GetVertex(name);
            startVertex.Dist = 0;
            vertices.Add(startVertex);

            while (vertices.Count > 0)
            {
                Vertex findMin = vertices.OrderBy(x => x.Dist).First();

                findMin.Known = true;
                vertices.Remove(findMin);

                foreach (Edge edge in findMin.Adj)
                {
                    if (edge.dest.Known) continue;

                    Vertex currentVertex = edge.dest;
                    double distance = findMin.Dist + edge.cost;

                    if (!(currentVertex.Dist > distance)) continue;
                    currentVertex.Dist = distance;
                    vertices.Add(currentVertex);
                }
            }
        }

        public bool IsConnected()
        {
            // list with all vertices
            List<Vertex> list = vertexMap.Values.ToList();

            // do unweighted algorithm for each vertex
            foreach (Vertex vertex in list)
            {
                Unweighted(vertex.Name);

                // check if there is a vertex with still infinity as distance
                // if so, it means that a certain vertex cannot be reached with the current start vertex
                // and that the graph is not a connected graph
                if (list.Any(l => l.Dist == INFINITY)) return false;
            }

            return true;
        }
    }
}