using System;

namespace EnumeratedTypes
{
    public class Program
    {

        static void PaintCar(CarColor color)
        {
            Console.WriteLine("The car was painted: {0} with the code {1}", color, (int)color);
        }

        enum CarColor : byte
        {
            Orange = 0,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void Main(string[] args)
        {
            PaintCar(CarColor.Red);
        }
    }
}