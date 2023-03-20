using System;

namespace Structs
{
    public class Program
    {

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public double Area()
            {
                return this.length * this.width;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(200, 233);
            Console.WriteLine("Area of rectangle: {0}", rectangle1.Area());
            Console.WriteLine("Area of rectangle: {0}", ShapeMath.GetArea("rectangle", rectangle1.length, rectangle1.width));
        }
    }
}