using System;
using System.Collections;

namespace ArrayLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList();

            aList.Add("Member1");
            aList.Add("43");

            Console.WriteLine("Count {0}", aList.Count);
            Console.WriteLine("Capacity {0}", aList.Capacity);

            ArrayList bList = new ArrayList();
            bList.AddRange(new object[] { "Member 2", "Member 3", "Member 4" });
            bList.AddRange(aList);

            aList.Sort();
            aList.Insert(1, "Turkey");

            bList.RemoveAt(1);
            bList.RemoveRange(2, 1);

            int i = aList.IndexOf("43", 0);

            foreach (object o in bList)
            {
                Console.WriteLine("Object {0}", o);
            }

            string[] myArray = (string[])aList.ToArray(typeof(string));
            string[] customers = { "Hawks", "Endeavor" };
            ArrayList customArrayList = new ArrayList();
            customArrayList.AddRange(customers);
        }
    }
}