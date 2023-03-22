using System;

namespace Threads
{
    public class Program
    {

        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
            }
        }

        static void CountTo(int maxNum)
        {
            for (int i = 0; i < maxNum; i++)
            {
                Console.Write(i);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(Print1);
            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }

            int num = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }

            Console.WriteLine("Thread Ends");

            BankAccount account = new BankAccount(10);
            Thread[] threads = new Thread[15];
            Thread.CurrentThread.Name = "main";

            for (int i = 0; i < 15; i++)
            {
                Thread thrr = new Thread(new ThreadStart(account.IssueWithdraw)); // only methods that does not return anything and take no parameters can be called
                thrr.Name = i.ToString();
                threads[i] = thrr;
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
            }

            Console.WriteLine("Current Priority: {0}", Thread.CurrentThread.Priority);
            Console.WriteLine("Threading ending: {0}", Thread.CurrentThread.Name);

            Thread t2 = new Thread(() => CountTo(10));
            t2.Start();

            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
                CountTo(7);
                CountTo(8);
            }).Start();
        }
    }
}