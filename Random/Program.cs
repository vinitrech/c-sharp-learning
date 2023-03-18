using System;

namespace Randomm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 11); // up to 11 not inclusive

            Console.WriteLine(secretNumber);
        }
    }
}