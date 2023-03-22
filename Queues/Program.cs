using System;
using System.Collections;

namespace Queues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains(2));
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(String.Join(",", numArray));

            foreach (object i in queue)
            {
                Console.WriteLine(i);
            }

            queue.Clear();
        }
    }
}