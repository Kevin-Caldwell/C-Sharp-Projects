using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagorasTriangle
{
    public class Edge
    {
        private Vertex _A;
        private Vertex _B;
        private double length;

        public Vertex A { get { return _A; } set { _A = value; } }
        public Vertex B { get { return _B; } set { _B = value; } }

        public double Length { get { return length; } set { length = value; } }

        public Edge()
        {
            _A = new Vertex();
            _B = new Vertex();
        }

        public Edge(Vertex A, Vertex B)
        {
            _A = A;
            _B = B;
        }
    }
}
