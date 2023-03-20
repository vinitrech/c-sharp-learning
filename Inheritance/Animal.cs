using System;

namespace Inheritance
{
    public class Animal
    {
        private string _name;
        protected string sound;
        protected AnimalIDInfo animalIdInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int number, string owner)
        {
            this.animalIdInfo.IDNumber = number;
            this.animalIdInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIdInfo.IDNumber} and is owned by {animalIdInfo.Owner}");
        }

        public virtual void MakeSound() // virtual allows to be overwritten
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal(string name, string sound)
        {
            this._name = name;
            this.sound = sound;
        }

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public string Sound
        {
            get
            {
                return this.sound;
            }

            set
            {
                this.sound = value;
            }
        }

        public class AnimalHealth // inner classes usually are helpers for the outer classes.
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if (weight > height)
                {
                    return false;
                }
                return true;
            }
        }
    }
}