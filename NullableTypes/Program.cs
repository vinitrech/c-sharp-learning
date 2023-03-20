using System;

namespace NullableTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? randNum = null;
            Console.WriteLine("randNum is equal to null: {0}", randNum == null);
            Console.WriteLine("randNum is equal to null: {0}", !randNum.HasValue);
        }
    }
}