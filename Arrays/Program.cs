using System;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] favoriteNumbers = new int[3];
            favoriteNumbers[0] = 22;

            Console.WriteLine("favoriteNumber 0 : {0}", favoriteNumbers[0]);

            string[] customers = { "customer1", "customer2", "customer3" };

            var employees = new[] { "Employee 1", "Employee 2", "Employee 3" };

            object[] randomArray = { 1, 2, "randomString", 1.234 };

            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());
            Console.WriteLine("Array size: {0}", randomArray.Length);
        }
    }
}