using System;

namespace Lambdas
{
    public class Program
    {
        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            doubleIt d = x => x * 2;

            Console.WriteLine($"5*2 = {d(5)}");

            List<int> numList = new List<int>() { 1, 9, 10, 11, 12, 13, 14, 15 };

            /************** WHERE **************/

            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var j in evenList)
            {
                Console.WriteLine(j);
            }

            var rangeList = numList.Where(x => (x > 2) || (x < 9)).ToList();
            foreach (var j in rangeList)
            {
                Console.WriteLine(j);
            }

            List<int> flipList = new List<int>();
            int i = 0;

            Random rnd = new Random();

            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            Console.WriteLine("Heads: {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails: {0}", flipList.Where(a => a == 2).ToList().Count());

            var nameList = new List<string> { "Name1", "Name2", "Name3", "Name4", "Name5" };
            var nNameList = nameList.Where(a => a.StartsWith("N"));

            foreach (var m in nNameList)
            {
                Console.WriteLine(m);
            }

            /************** SELECT **************/

            var oneToTen = new List<int>();

            oneToTen.AddRange(Enumerable.Range(1, 10));
            var squares = oneToTen.Select(x => x * x);

            foreach (var l in squares)
            {
                Console.WriteLine(l);
            }

            /************** ZIP **************/

            var listOne = new List<int>(new int[] { 1, 2, 3 });
            var listTwo = new List<int>(new int[] { 4, 5, 6 });

            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            foreach (var item in sumList)
            {
                Console.WriteLine(item);
            }

            /************** AGREGATE **************/

            var listOne2 = new List<int>(new int[] { 1, 2, 3 });

            Console.WriteLine(listOne.Aggregate((a, b) => a + b));
            Console.WriteLine(listOne.AsQueryable().Average());


            /************** ALL / ANY / DISTINCT / EXCEPT / INTERSECT **************/

            var listOne3 = new List<int>(new int[] { 1, 2, 3, 3, 3, 3, 3, 4 });

            Console.WriteLine(listOne.All(x => x > 2));
            Console.WriteLine(listOne.Any(x => x > 2));

            Console.WriteLine(String.Join(", ", listOne3.Distinct()));
            Console.WriteLine(String.Join(", ", listOne3.Except(listOne)));
            Console.WriteLine(String.Join(", ", listOne3.Intersect(listOne)));
        }
    }
}