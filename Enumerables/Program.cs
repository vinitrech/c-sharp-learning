using System;

namespace Enumerables
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm myAnimals = new AnimalFarm();

            myAnimals[0] = new Animal("Wilbur");
            myAnimals[1] = new Animal("Wilbur2");
            myAnimals[2] = new Animal("Wilbur3");
            myAnimals[3] = new Animal("Wilbur4");
            myAnimals[4] = new Animal("Wilbur5");
            myAnimals[5] = new Animal("Wilbur6");

            foreach (Animal a in myAnimals)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}