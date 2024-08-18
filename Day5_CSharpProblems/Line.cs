using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_CSharpProblems
{
    internal class Line
    {
        private Point2D Point1 { get; set; }
        private Point2D Point2 { get; set; }

        public Line(Point2D p1, Point2D p2)
        {
            Point1 = p1;
            Point2 = p2;
        }

        public double GetLength()
        {
            int deltaX = Point2.X - Point1.X;
            int deltaY = Point2.Y - Point1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
