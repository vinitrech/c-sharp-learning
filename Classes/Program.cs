using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
       public: Can be accessed from other classes
       private: Cannot be accessed by other classes
       protected: Can only be accessed by derived classes 
       sealed: cannot be inherited by any class but can be instantiated
       internal: Middle term between public and private. Only accessible by the files in the same assembly (same project - each project - console app (.exe) or library (dll) for example - creates an assembly) <- default access modifier       
       */

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
