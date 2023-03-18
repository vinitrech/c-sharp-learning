using System;
using System.Globalization;
using System.Text;

namespace StringBuilderr
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Random text"); // default is 16 characters and can grow automatically
            StringBuilder sbFixedSize = new StringBuilder("More random text", 256);

            Console.WriteLine("Capacity: {0}", sbFixedSize.Capacity);
            Console.WriteLine("Length: {0}", sbFixedSize.Length);

            sbFixedSize.AppendLine("\nEven More random text");
            Console.WriteLine("Content of sbFixed: {0}", sbFixedSize);

            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
            string bestCustomer = "Bob Smith";
            sbFixedSize.AppendFormat(enUs, "Best customer: {0}", bestCustomer);
            Console.WriteLine(sbFixedSize.ToString());

            sbFixedSize.Replace("text", "characters");
            Console.WriteLine(sbFixedSize.ToString());

            sbFixedSize.Clear();
            sbFixedSize.Insert(0, "Fixed");
            Console.WriteLine(sbFixedSize.ToString());

            sbFixedSize.Remove(0, 2);
            Console.WriteLine(sbFixedSize.ToString());
        }
    }
}