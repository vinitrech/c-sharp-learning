using System;

namespace Functions
{
    public class Program
    {

        static void PrintArray(int[] arr, string message)
        {
            Console.WriteLine("Printing array => {0}", message);
            Console.WriteLine();

            foreach (int value in arr)
            {
                Console.WriteLine("{0}", value);
            }
        }

        static void Main(string[] args)
        {
            int[] integers = { 0, 5, 1, 3, 4, 2, 6, 8, 7, 0 };

            PrintArray(integers, "Print integers array");

            Array.Sort(integers);
            PrintArray(integers, "Sorted integers array");

            Array.Reverse(integers);
            PrintArray(integers, "Reversed integers array");

            Console.WriteLine("1 at index {0}", Array.IndexOf(integers, 1));

            integers.SetValue(0, 1);
            PrintArray(integers, "Setting 1 to 0");

            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int length = 2;
            Array.Copy(srcArray, destArray, length);
            PrintArray(destArray, "Copying array");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);

            foreach (int val in anotherArray)
            {
                Console.WriteLine("value: {0}", val);
            }

            int[] numbers = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.Find(numbers, element => element > 10));
        }
    }
}