using System;

namespace BinaryWritersOrReaders
{
    public class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"C:\Users\RandomUser\textfile.txt";

            FileInfo fileInfo = new FileInfo(textFilePath);
            BinaryWriter bw = new BinaryWriter(fileInfo.OpenWrite());

            string randomText = "Random text";
            int age = 40;
            double height = 6.25;

            bw.Write(randomText);
            bw.Write(age);
            bw.Write(height);
            bw.Close();

            BinaryReader reader = new BinaryReader(fileInfo.OpenRead());
            Console.WriteLine(reader.ReadString());
            Console.WriteLine(reader.ReadInt32());
            Console.WriteLine(reader.ReadDouble());
            reader.Close();
        }
    }
}