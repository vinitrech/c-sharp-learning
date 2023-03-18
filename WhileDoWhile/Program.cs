using System;

namespace WhileDoWhile
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int index = 0;

            while (index < numbers.Length)
            {
                if (numbers[index] % 2 != 0)
                {
                    index++;
                    continue; // jumps to next iteration
                }

                if (index == 10) break;

                Console.WriteLine("Number {0}", numbers[index]);
                index++;
            }

            bool condition = false;

            do
            {
                Console.WriteLine("Executing");
            } while (condition);
        }
    }
}