using System;

namespace Classes
{
    public class ClassExample
    {
        public string Message { get; set; }

        public ClassExample(string message)
        {
            Message = message;
        }

        public void PrintMessage()
        {
            Console.WriteLine(Message);
        }
    }
}