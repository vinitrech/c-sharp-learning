using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal fox = new Animal()
            {
                name = "Fox",
                sound = "Raaw"
            };

            Animal dog = new Animal("Dog", "Barf");
            dog.MakeSound();

            Console.WriteLine("Number of animals: {0}", Animal.GetNumberOfAnimals());
        }
    }
}
