using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_CSharpProblems
{
    internal class Square : Rectangle
    {
        public Square(Point2D topLeft, int sideLength)
       : base(topLeft, new Point2D(topLeft.X + sideLength, topLeft.Y + sideLength))
        {
        }
    }
}
