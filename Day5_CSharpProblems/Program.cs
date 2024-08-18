using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_CSharpProblems
{

    internal class Program
    {
       
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(0, 0);
            Point2D p2 = new Point2D(3, 4);
            Line line = new Line(p1, p2);

            Console.WriteLine($"Length of the line: {line.GetLength()}");

            //---------------------------
            Point2D topLeft = new Point2D(0, 0);
            Point2D bottomRight = new Point2D(4, 3);
            Rectangle rectangle = new Rectangle(topLeft, bottomRight);
            Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea()}");
            //----------------------------

            Square square = new Square(new Point2D(0, 0), 5);
            Console.WriteLine($"Area of the square: {square.CalculateArea()}");
        }
    }
}
