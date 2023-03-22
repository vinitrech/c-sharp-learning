using System;
using System.Collections;

namespace LINQ
{
    public class Program
    {

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30 };

            var gt20 = from num in nums where num > 20 orderby num select num;

            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Get type {0}", gt20.GetType());

            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;

            foreach (int num in gt20)
            {
                Console.WriteLine(num);
            }

            return arrayGT20;
        }

        static void Main(string[] args)
        {
            string[] dogs = { "K9", "K 1", "K 2", "K 3", "K4" };

            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog descending select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            int[] array = QueryIntArray();

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            ArrayList famAnimals = new ArrayList(){
                new Animal("Animal 1", 18, .8),
                new Animal("Animal 2", 13, .4),
                new Animal("Animal 3", 15, .6),
                new Animal("Animal 4", 11, .2),
            };

            var famAnimalsEnum = famAnimals.OfType<Animal>();
            var smallAnimals = from animal in famAnimalsEnum
                               where animal.Weight < 91
                               orderby animal.Name
                               select animal;

            foreach (var animal in smallAnimals)
            {
                Console.WriteLine(animal.Name, animal.Weight, animal.Height);
            }
        }
    }
}