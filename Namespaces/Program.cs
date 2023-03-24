using System;
using Classes;
using Models;

namespace Namespaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassExample classExample = new ClassExample("message from class");
            ExampleModel modelExample = new ExampleModel("message from model");

            classExample.PrintMessage();
            modelExample.PrintMessage();
        }
    }
}