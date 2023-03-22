using System;
using System.IO;

namespace FileIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] customers = {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = @"C:\Users\randomFolder\text.txt";
            File.WriteAllLines(textFilePath, customers);

            foreach (string customer in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine(customer);
            }


            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\randomFolder");
            FileInfo[] textFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine(textFiles.Length);

            foreach (FileInfo file in textFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length + "\n");
            }
        }
    }
}