using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagorasTriangle
{
    public class Square
    {
        public Vertex A;
        public Vertex B;
        public Vertex C;
        public Vertex D;

        private List<Edge> edges = new List<Edge>();

        public List<Edge> Edges { get { return edges; } set { edges = value; } }

        public double angle;
        private double sideLength;

        private int height;

        public double Side { get { return sideLength; } set { sideLength = value; } }

        public int Height { get { return height; } }

        public Square(Vertex lowerVertex, double length, double angle)
        {
            sideLength = length;
            this.angle = angle;

            A = lowerVertex;
            B = new Vertex(A.X + sideLength * Math.Cos(angle), A.Y + sideLength * Math.Sin(angle));
            C = new Vertex(A.X + sideLength * 1.414213562 * Math.Cos(angle + Math.PI / 4), A.Y + sideLength * 1.414213562 * Math.Sin(angle + Math.PI / 4));
            D = new Vertex(A.X + sideLength * Math.Sin(-1 * angle), A.Y + sideLength * Math.Cos(angle));
            
            edges.Add(new Edge(A, B));
            edges.Add(new Edge(B, C));
            edges.Add(new Edge(C, D));
            edges.Add(new Edge(D, A));

        }

        public void getPythagorasSquares(int height, List<Square> pythagorasSquares, double rightAngle)
        {
            this.height = height;
            if (height > 1)
            {
                Square secondSquare = new Square(D, sideLength * Math.Cos(rightAngle), (angle + rightAngle));
                Square thirdSquare = new Square(secondSquare.B, sideLength * Math.Sin(rightAngle), rightAngle + angle - Math.PI/2);

                pythagorasSquares.Add(secondSquare);
                pythagorasSquares.Add(thirdSquare);

                secondSquare.getPythagorasSquares(height - 1, pythagorasSquares, rightAngle);
                thirdSquare.getPythagorasSquares(height - 1, pythagorasSquares, rightAngle);
            }
        }
    }
}
