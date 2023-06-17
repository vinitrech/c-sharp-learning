using System;

// Null should be checked with "is null" or "is not null"

namespace NullableTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? randNum = null;
            Console.WriteLine("randNum is equal to null: {0}", randNum == null);
            Console.WriteLine("randNum is equal to null: {0}", !randNum.HasValue);

            int? testNull = null;
            testNull ??= 5; // if testNull is null, assign 5

            Console.WriteLine("testNull is equal to null: {0} with value {1}", testNull is null, testNull);

            int? testNull2 = testNull ?? 10; // if testNull is null, assign 10. If is not null, assign testNull
            Console.WriteLine("testNull2 is equal to null: {0} with value {1}", testNull2 == null, testNull2);
        }
    }
}