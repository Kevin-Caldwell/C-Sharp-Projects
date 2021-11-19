using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythagorasTriangle
{
    public partial class PythagorasForm : Form
    {
        #region Data Members of 'Pythagoras Form'
        private int _screenWidth, _screenHeight;

        private Bitmap squareBitmap;
        private Graphics squareDrawingSurface;

        private Vertex startVertex;
        private double length = 100;
        private double angle = 3.14;

        private double rightAngle = Math.PI / 4;
        private int iterations = 1;

        #endregion
        public PythagorasForm()
        {
            InitializeComponent();
            _screenWidth = pythagorasPictureBox.Width;
            _screenHeight = pythagorasPictureBox.Height;
            squareBitmap = new Bitmap(_screenWidth, _screenHeight);
            squareDrawingSurface = Graphics.FromImage(squareBitmap);

            startVertex = new Vertex((double)_screenWidth / 2, (double)_screenHeight - 10);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(squareBitmap, 0, 0);
        }

        private void angleTrackBar_ValueChanged(object sender, EventArgs e)
        {
            angle = (double)iterationsTrackBar.Value / 100;
            AngleLabel.Text = angle + "";
            drawSquares();
        }

        private void sideLengthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            length = (double)sideLengthTrackBar.Value;
            drawSquares();
            
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            drawSquares();
        }

        private void iterationsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            iterations = iterationsTrackBar.Value + 1;
            drawSquares();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            rightAngle = (double)trackBar1.Value / 100;
            AngleLabel.Text = rightAngle + "";
            drawSquares();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            double increment = 0.01;
            if (rightAngle > 1.67 | rightAngle < 0)
            {
                increment *= -1;
            }
            rightAngle += increment;

            drawSquares();
        }

        private void drawSquares()
        {
            squareDrawingSurface.Clear(pythagorasPictureBox.BackColor);
            Graphics g = Graphics.FromImage(squareBitmap);

            Square startSquare = new Square(startVertex, length, angle);
            List<Square> pythagorasSquareList = new List<Square>();

            pythagorasSquareList.Add(startSquare);
            startSquare.getPythagorasSquares(iterations, pythagorasSquareList, rightAngle);

            foreach (Square square in pythagorasSquareList)
            {
                Point[] squarePoints = {square.A.getPoint(), square.B.getPoint(), square.C.getPoint(), square.D.getPoint() };
                Pen pen = new Pen(Color.FromArgb(255 / square.Height, 255, 255));
                

                g.DrawPolygon(Pens.BlueViolet, squarePoints);
            }

            pythagorasPictureBox.Refresh();
        }

    }
}
