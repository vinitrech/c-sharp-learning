using System;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 200);

            if (buick is IDrivable) // checking if it implements the interface that contains the methods' signatures
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("Can't be driven");
            }
        }
    }
}