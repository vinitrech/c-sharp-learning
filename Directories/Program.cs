using System;
using System.IO;

namespace Directories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(".");
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\user");
            Console.WriteLine(directory.FullName);
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.Parent);
            Console.WriteLine(directory.Attributes);
            Console.WriteLine(directory.CreationTime);

            DirectoryInfo dataDirectory = new DirectoryInfo("./data");
            dataDirectory.Create();
            Directory.Delete(@"C:\Users\randomFolder");
        }
    }
}