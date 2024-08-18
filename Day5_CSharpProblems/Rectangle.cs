using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_CSharpProblems
{
    internal class Rectangle
    {
        protected Point2D TopLeft { get; set; }
        protected Point2D BottomRight { get; set; }

        public Rectangle(Point2D topLeft, Point2D bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public int CalculateArea()
        {
            int width = Math.Abs(BottomRight.X - TopLeft.X);
            int height = Math.Abs(BottomRight.Y - TopLeft.Y);
            return width * height;
        }
    }
}
