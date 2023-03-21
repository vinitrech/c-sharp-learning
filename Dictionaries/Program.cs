using System;
using System.Collections.Generic;

namespace Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();

            names.Add("Example key", "value for example key");
            names.Add("Example key 2", "value for example key 2");
            names.Add("Example key 3", "value for example key 3");

            names.Remove("Example key");

            Console.WriteLine(names.Count);
            Console.WriteLine("Example key 2 index: {0}", names.ContainsKey("Example key 2"));

            names.TryGetValue("value for example key", out string test);
            Console.WriteLine(test);

            foreach (KeyValuePair<string, string> pair in names)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
                Console.WriteLine();
            }

            names.Clear();
        }
    }
}