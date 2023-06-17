using System;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            List<int> numberList = new List<int>();

            numberList.Add(24);

            animalList.Add(new Animal("Doug"));
            animalList.Add(new Animal("Pock"));
            animalList.Add(new Animal("Shuck"));

            animalList.Insert(1, new Animal("Jit"));
            animalList.RemoveAt(2);

            Console.WriteLine(animalList.Count());

            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Name);
            }

            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            string x2 = "5", y2 = "4";
            Animal.GetSum<string>(ref x2, ref y2);

            Rectangle<int> rect = new Rectangle<int>(24, 32);
            Console.WriteLine(rect.GetArea());

            Rectangle<string> rect2 = new Rectangle<string>("24", "32");
            Console.WriteLine(rect2.GetArea());
        }

        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double widthDouble = Convert.ToDouble(Width);
                double lengthDouble = Convert.ToDouble(Length);

                return String.Format($"{Width} * {Length} = {widthDouble * lengthDouble}");
            }

            public T Width
            {
                get
                {
                    return width;
                }

                set
                {
                    width = value;
                }
            }
            public T Length
            {
                get
                {
                    return length;
                }
                set
                {
                    length = value;
                }
            }
        }
    }
}

/*********************** IEnumerable x IQueryable ***********************/
// IEnumerable will not apply filters in the query, it will load all records in memory an then apply filters
// IQueryable will apply filters in the query itself, only returning the matching records from the database

/*********************** IEnumerable x ICollection x IList ***********************/
// IEnumerable provides basic features for iteration
// ICollection inherits from IEnumerable and adds features to add/remove items
// IList inherits from ICollection and adds features to add/remove items at specific indexes

/*********************** IEnumerable specifics ***********************/
// Deferred execution