using System;

namespace OperatorOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);

            Box box3 = box1 + box2;

            Console.WriteLine(box3);
            Console.WriteLine((int)box3);

            Box box4 = (Box)4;
            Console.WriteLine(box4);

            var shopkins = new { Name = "Shopkins", Price = 4.99 };
            Console.WriteLine("{0} cost {1}", shopkins.Name, shopkins.Price);

            var toyArray = new[] {
                new {
                    Name = "Toyota",
                    Price = 5.99
                },
                new {
                    Name = "Toyota2",
                    Price = 9.99
                }
            };

            foreach (var item in toyArray)
            {
                Console.WriteLine("{0} cost {1}", item.Name, item.Price);
            }
        }
    }
}