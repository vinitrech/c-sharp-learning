using System;
using System.Net.Http.Headers;

namespace Functions
{
    public class Program
    {

        /************************* ASYNC / AWAIT *************************/

        /* A task in C# is used to implement Task-based Asynchronous Programming. 
        The Task object is typically executed asynchronously on a thread pool 
        thread rather than synchronously on the main thread of the application.*/

        /* async - Signals to the compiler that this method contains an await statement; it contains asynchronous operations.
        await - The await keyword provides a non-blocking way to start a task, then continue execution when that task completes.*/

        //*Bonus* for further use 
        /*ActionResult - An action is capable of returning a specific data type (see WeatherForecastController action).  
        When multiple return types are possible, it's common to return ActionResult, IActionResult or ActionResult<T>, 
        where T represents the data type to be returned.*/

        public static async Task<IEnumerable<User>> GetUsersAsync(IEnumerable<int> userIds)
        {
            var getUserTasks = new List<Task<User>>();
            foreach (int userId in userIds)
            {
                getUserTasks.Add(GetUserAsync(userId));
            }

            return await Task.WhenAll(getUserTasks);
        }

        private static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }

        static void PrintArray(int[] arr, string message)
        {
            Console.WriteLine("Printing array => {0}", message);
            Console.WriteLine();

            foreach (int value in arr)
            {
                Console.WriteLine("{0}", value);
            }
        }

        /****************************** PASSING BY VALUE ******************************/
        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }

        /****************************** PASSING BY REFERENCE ******************************/
        static void DoubleIt(int x, out int solution) // out = the parameter passed MUST be modified by the metho (Passing by reference);
        {
            solution = x * 2;
        }

        public static void Swap(ref int x, ref int y) // ref = the parameter passed MAY be modified by the method (Passing by reference);
        {
            int aux = x;
            x = y;
            y = aux;
        }

        /****************************** UNKNOWN NUMBER OF PARAMETERS ******************************/
        static double GetSumMore(params double[] numbers) // if there are more parameters, the dynamic part should always come last
        {
            double sum = 0;
            foreach (double i in numbers)
            {
                sum += i;
            }

            return sum;
        }

        /****************************** NAMED PARAMETERS ******************************/
        static void PrintInfo(string name, string zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }


        /****************************** METHOD OVERLOADING ******************************/
        static double GetSumGeneric(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }

        static double GetSumGeneric(string num1 = "1", string num2 = "1")
        {
            return Convert.ToDouble(num1) + Convert.ToDouble(num2);
        }


        static void Main(string[] args)
        {
            int[] integers = { 0, 5, 1, 3, 4, 2, 6, 8, 7, 0 };

            PrintArray(integers, "Print integers array");

            Array.Sort(integers);
            PrintArray(integers, "Sorted integers array");

            Array.Reverse(integers);
            PrintArray(integers, "Reversed integers array");

            Console.WriteLine("1 at index {0}", Array.IndexOf(integers, 1));

            integers.SetValue(0, 1);
            PrintArray(integers, "Setting 1 to 0");

            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int length = 2;
            Array.Copy(srcArray, destArray, length);
            PrintArray(destArray, "Copying array");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);

            foreach (int val in anotherArray)
            {
                Console.WriteLine("value: {0}", val);
            }

            int[] numbers = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.Find(numbers, element => element > 10));

            SayHello("Some name");

            double x = 5;
            double y = 4;

            Console.WriteLine("{0} + {1} = {2}", x, y, GetSum(x, y)); // passing by value

            int solution;
            DoubleIt(15, out solution); // passing solution by reference
            Console.WriteLine("Value of solution: {0}", solution);

            int number3 = 10;
            int number4 = 20;
            Console.WriteLine("Before swap number3: {0}, number4: {1}", number3, number4);
            Swap(ref number3, ref number4); // passing by reference
            Console.WriteLine("After swap number3: {0}, number4: {1}", number3, number4);


            Console.WriteLine(GetSumMore(1.0, 2, 3.3, 4, 5.1, 6, 7)); // variable number of parameters

            PrintInfo(zipCode: "022918212", name: "Random Name"); // random order of parameters using named parameters

            Console.WriteLine("Double sum: {0} - String sum: {1} ", GetSumGeneric(1, 2), GetSumGeneric("1", "2"));
        }
    }
}