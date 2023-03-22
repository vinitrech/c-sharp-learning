using System;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arithmetic add, sub, addSub;
            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;

            Console.WriteLine("add: {0} and {1}", 6, 10);
            add(6, 10);

            Console.WriteLine("sub: {0} and {1}", 6, 10);
            sub(6, 10);

            Console.WriteLine("add: {0} and {1}", 6, 10);
            addSub(6, 10);
        }

        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }
    }
}