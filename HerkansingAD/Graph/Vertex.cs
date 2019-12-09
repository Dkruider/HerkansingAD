using System.Collections.Generic;

namespace Huiswerk6
{
    public class Vertex : IVertex
    {
        public string Name;
        public Vertex Prev;
        public double Dist;
        public bool Known;
        public List<Edge> Adj;

        public Vertex(string name)
        {
            Name = name;
            Dist = Graph.INFINITY;
            Known = false;
            Adj = new List<Edge>();
        }

        public void Reset()
        {
            Dist = Graph.INFINITY;
            Known = false;
            Prev = null;
        }

    }
}