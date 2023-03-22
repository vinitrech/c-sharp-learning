using System;
using System.Collections;

namespace Stacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Contains(1));

            object[] numArray = stack.ToArray();

            Console.WriteLine(String.Join(",", numArray));

            foreach (object i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}