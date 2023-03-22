using System;

namespace StreamWriterAndStreamReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"C:\Users\randomUser\file.txt";

            StreamWriter sw = new StreamWriter(textFilePath);
            sw.Write("Random string");
            sw.WriteLine("Sentence");
            sw.WriteLine("This is another sentence");
            sw.Close();

            StreamReader sr = new StreamReader(textFilePath);
            Console.WriteLine("Peek: {0}", Convert.ToChar(sr.Peek()));

            Console.WriteLine("1st String : {0}", sr.ReadLine());

            Console.WriteLine("Everything else: {0}", sr.ReadToEnd());
        }
    }
}