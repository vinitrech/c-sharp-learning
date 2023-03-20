using System;

namespace GettersSetters
{
    public class Program
    {
        static void Main(string[] args)
        {

            // The preferred method is to use Properties to manipulate fields (which should be private).
            Animal animal1 = new Animal("Animal 1", "Sound 1");
            Animal animal2 = new Animal("Animal 2", "Sound 2");

            Console.WriteLine("Animal1 {0} sounds like {1}", animal1.GetName(), animal1.GetSound());

            animal2.Sound = "asdfasdfsdfasdfasdf";
            Console.WriteLine("Animal2 sound after change: {0}", animal2.Sound);
            Console.WriteLine("Owner: {0}", animal2.Owner);
            animal2.Owner = "New owner";
            Console.WriteLine("Owner: {0}", animal2.Owner);
            animal2.Name = "New name for animal 2";
            animal2.Sound = "New sound for animal 2";
            Console.WriteLine("Animal 2: {0}, {1}", animal2.Name, animal2.Sound);

            Console.WriteLine("Number of Animals: {0}", Animal.GetNumberOfAnimals());
            Console.WriteLine("Number of Animals: {0}", Animal.NumberOfAnimals);
        }
    }
}