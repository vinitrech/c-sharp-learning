using System;

namespace ForLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int x = 0; x < integers.Length; x++)
            {
                Console.WriteLine("index: {0} - value: {1}", x, integers[x]);
            }

            foreach (int x in integers)
            {
                Console.WriteLine("Value: {0}", x);
            }

            int[,] matrix = new int[2, 2] { { 0, 1 }, { 2, 3 } };

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.WriteLine("index x: {0} - index y: {1} - value: {2}", x, y, matrix[x, y]);
                }
            }

            int[,,] matrix3d = new int[2, 2, 2] { { { 0, 1 }, { 2, 3 } }, { { 4, 5 }, { 6, 7 } } };

            for (int x = 0; x < matrix3d.GetLength(0); x++)
            {
                for (int y = 0; y < matrix3d.GetLength(1); y++)
                {
                    for (int z = 0; z < matrix3d.GetLength(2); z++)
                    {
                        Console.WriteLine("index x: {0} - index y: {1} - index z: {2} - value: {3}", x, y, z, matrix3d[x, y, z]);
                    }
                }
            }

            Console.WriteLine("\n================================\n");

            foreach (int i in returnFirstNumber(10))
            {
                Console.WriteLine("Resultado de {0}", i);
            }
        }

        // YIELD <-> Use the yield statement in an iterator to provide (return) the next value from a sequence when iterating over it.
        public static IEnumerable<int> returnFirstNumber(int upTo)
        {
            for (int x = 0; x < upTo; x++)
            {
               Thread.Sleep(1000);
               
               Console.WriteLine("Yield de: {0}", x);
               yield return x;
            }
        }
    }
}