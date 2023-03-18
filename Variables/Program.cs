using System;

namespace Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool canIVote = true;
            int intValue = 0; // 32 bit
            long longValue = 0; // 64 bit
            decimal decimalValue = 0.0M; // 128 bits up to 29 digits precision
            double doubleValue = 1.0; // 64 bit up to 17 digits precision
            float floatValue = 1.0F; // 32 bit up to 9 digits precision
            byte byteValue = 1; // 8 bits
            char charValue = 's'; // 16 bits unicode character
            sbyte signedByte = 1; // 8 bit signed int
            short shortValue = -2; // 16 bit unsigned int
            uint uintValue = 2; // 32 bit unsigned int
            ulong ulongValue = 2; // 64 bit unsigned long
            ushort ushortValue = 2; // 16 bit unsigned short

            /*********************** CASTING ***********************/

            bool boolFromString = bool.Parse("true");
            int intFromString = int.Parse("100");
            double doubleFromString = double.Parse("1.234");
            string stringFromDouble = doubleFromString.ToString();

            /*********************** GETTING TYPES ***********************/

            Console.WriteLine($"Data type : {stringFromDouble.GetType()}");
            Console.WriteLine($"Explicit conversion - losing some data: {(int)1234.221}");
            Console.WriteLine($"Implicit conversion - no data loss: {(long)1}");

            /*********************** FORMATTING OUTPUT ***********************/

            Console.WriteLine("Currency : {0:c}", 23.455); // $23.45
            Console.WriteLine("Pad with 0s : {0:d4}", 23); // 0023
            Console.WriteLine("3 Decimals : {0:f3}", 23.12341234); // 23.123
            Console.WriteLine("Commas : {0:n4}", 23000000); // 2,300.0000

            /*********************** STRING FUNCTIONS ***********************/

            string randomString = "bunch of characters - is";
            Console.WriteLine("String length: {0}", randomString.Length); // 24
            Console.WriteLine("String contains 'is': {0}", randomString.Contains("is")); // True
            Console.WriteLine("Index of 'is': {0}", randomString.IndexOf("is")); // 22
            Console.WriteLine("Remove string : {0}", randomString.Remove(5, 8)); // buncharacters - is
            Console.WriteLine("Add string : {0}", randomString.Insert(7, " AddedItem ")); // bunch o AddedItem f characters - is
            Console.WriteLine("Replace string : {0}", randomString.Replace("bunch", "*REPLACED*")); // *REPLACED* of characters - is
            Console.WriteLine("Compare strings : {0}", String.Compare("A", "A", StringComparison.OrdinalIgnoreCase)); // 0
            Console.WriteLine("Compare strings : {0}", String.Compare("B", "A", StringComparison.OrdinalIgnoreCase)); // 1
            Console.WriteLine("Compare strings : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase)); // -1
            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase)); // True
            Console.WriteLine("Pad left : {0}", randomString.PadLeft(31, '-')); // -------bunch of characters - is
            Console.WriteLine("Pad right : {0}", randomString.PadRight(31, '-')); // bunch of characters - is-------
            Console.WriteLine("Trim whitespaces : {0}", randomString.Trim()); // bunch of characters - is
            Console.WriteLine("Uppercase all characters : {0}", randomString.ToUpper()); // BUNCH OF CHARACTERS - IS
            Console.WriteLine("Lowercase all characters : {0}", randomString.ToLower()); // bunch of characters - is
            Console.WriteLine("String made with Format: {0}", String.Format("{0} saw a {1} {2} in the {3}!", "Paul", "rabbit", "eating", "woods")); // Paul saw a rabbit eating in the woods!
            Console.Write("Hello" + "\n"); // Hello
            Console.Write("a \' \" \'' \""); // a ' " '' "
            Console.Write(@"\n\n\n\n\n\n"); // \n\n\n\n\n\n

        }
    }
}