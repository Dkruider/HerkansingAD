namespace Huiswerk6
{
    public class Edge
    {
        public Vertex dest;
        public double cost;

        public Edge(Vertex d, double c)
        {
            dest = d;
            cost = c;
        }
    }
}