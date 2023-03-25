using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;

namespace ReadOnly
{
    class Animal
    {
        private string _name;
        private string _sound;
        private static int _counter = 0;
        public readonly int id = 8; // setted at creation or/and inside constructor, immutable after. 
        //Example: There is a private readonly field declared in the class but it is assigned a value only in the constructor via dependence injection

        public Animal() : this("No name", "No sound")
        {
            _counter++;
            this.id = new Random().Next(1, 281982892);
        }

        public Animal(string name) : this(name, "No sound")
        {
            _counter++;
            this.id = new Random().Next(1, 281982892);
        }

        public Animal(string name, string sound)
        {
            _counter++;
            this.Name = name;
            this.Sound = sound;
            this.id = new Random().Next(1, 281982892);
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", this.Name, this.Sound);
        }

        public static int GetNumberOfAnimals()
        {
            return _counter;
        }

        /******************** Getters and Setters ********************/

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this._name = name;
            }
            else
            {
                this._name = "No name";
                Console.WriteLine("Name can't contain numbers!");
            }
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetSound(string sound)
        {
            if (sound.Length > 10) // value is the new assignment's content
            {
                this._sound = "No sound!";
                Console.WriteLine("Sound is too long!");
            }
            else
            {
                this._sound = sound;
            }
        }

        public string GetSound()
        {
            return this._sound;
        }


        /******************** Getters and Setters - Properties (fields should be declared as private and manipulated through properties) ********************/

        public string Name
        {
            get
            {
                return this._name + "abbbbbbbbb";
            }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    this._name = value;
                }
                else
                {
                    this._name = "No name";
                    Console.WriteLine("Name can't contain numbers!");
                }
            }
        }

        public string Sound
        {
            get
            {
                return this._sound + "abbbbbbbbb";
            }
            set
            {
                if (value.Length > 10) // value is the new assignment's content
                {
                    this._sound = "No sound!";
                    Console.WriteLine("Sound is too long!");
                }
                else
                {
                    this._sound = value;
                }
            }
        }

        public static int NumberOfAnimals
        {
            get { return _counter; }
        }

        /******************** Getters and Setters - Properties with default values ********************/

        public string Owner { get; set; } = "No Owner";
    }
}

