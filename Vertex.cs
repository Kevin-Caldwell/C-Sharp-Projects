using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PythagorasTriangle
{
    public class Vertex
    {
        private double _x, _y;

        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }

        public Vertex()
        {
            _x = 0;
            _y = 0;
        }

        public Vertex(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point getPoint()
        {
            return new Point((int)X, (int)Y);
        }

    }
}
