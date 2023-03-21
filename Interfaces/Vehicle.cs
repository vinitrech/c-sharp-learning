using System.Reflection;

namespace Interfaces
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }

        public Vehicle(string brand = "No brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public double Speed { get; set; }
        public int Wheels { get; set; }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped");
            Speed = 0;
        }
    }
}