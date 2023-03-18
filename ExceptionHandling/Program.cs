using System;

namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("Division by zero: {0}", num1 / num2);
                throw new System.DivideByZeroException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred: {0}", e.GetType().Name);
                Console.WriteLine("Message: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Execute this always");
            }
        }
    }
}