using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("Whiskers", "Meow");
            Dog dog = new Dog("Grover", "Barf", "Woof");

            dog.MakeSound();
            cat.MakeSound();

            cat.SetAnimalIDInfo(1, "Cat owner");
            dog.SetAnimalIDInfo(2, "Dog owner");

            cat.GetAnimalIDInfo();
            dog.GetAnimalIDInfo();

            Animal.AnimalHealth examinePet = new Animal.AnimalHealth();
            Console.WriteLine("Testing health checker: {0}", examinePet.HealthyWeight(11, 22));
            Console.WriteLine("Testing health checker: {0}", examinePet.HealthyWeight(22, 11));

            Animal testDog = new Dog("Grover2", "Barf2", "Woof2");
            testDog.MakeSound();
        }
    }
}