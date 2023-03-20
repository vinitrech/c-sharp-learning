using System;

namespace Inheritance
{
    // Inheritance is achieved by using : symbol, equivalent to java's extends
    public class Dog : Animal
    {

        public Dog(string name = "No name", string sound = "No sound", string sound2 = "No Sound") : base(name, sound) // invoking parent constructor
        {
            this.Sound2 = sound2;
        }

        public string Sound2
        {
            get; set;
        } = "Grrrr";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and also {Sound2}");
        }
    }
}