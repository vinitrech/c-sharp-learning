using System.Diagnostics.Metrics;

namespace Classes
{
    class Animal
    {
        public string name;
        public string sound;
        static int counter = 0;

        public Animal()
        {
            this.name = "No name";
            this.sound = "No sound";
            counter++;
        }

        public Animal(string name = "No name")
        {
            this.name = name;
            this.sound = "No sound";
            counter++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            counter++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumberOfAnimals()
        {
            return counter;
        }
    }
}

