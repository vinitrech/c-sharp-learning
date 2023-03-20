using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;

namespace GettersSetters
{
    class Animal
    {
        private string _name;
        private string _sound;
        private static int _counter = 0;

        public Animal()
        {
            this._name = "No name";
            this._sound = "No sound";
            _counter++;
        }

        public Animal(string name = "No name")
        {
            this._name = name;
            this._sound = "No sound";
            _counter++;
        }

        public Animal(string name = "No Name", string sound = "No Sound")
        {
            this._name = name;
            this._sound = sound;
            _counter++;
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

