using System;

namespace IfElseElseIf
{
    public class Program
    {

        static void Main(string[] args)
        {

            int age = 51;

            if ((age >= 10) && (age <= 50))
            {
                Console.Write("Age between 10 and 50");
            }
            else if (age < 10)
            {
                Console.Write("Age smaller than 10");
            }
            else
            {
                Console.WriteLine("Age above 50 - {0}", !true);
            }

            bool canDrive = age > 15 ? true : false;

            Console.WriteLine("Can drive: {0}", canDrive);

            string name1 = "Name 1";
            string name2 = "Name 2";

            if (name1.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal");
            }
        }
    }
}