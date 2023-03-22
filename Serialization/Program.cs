using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal enamol = new Animal("Animal1", 35, 25, 1);
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, enamol);
            stream.Close();

            enamol = null;

            stream = File.Open("AnimalData.dat", FileMode.Open);
            formatter = new BinaryFormatter();

            enamol = (Animal)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine(enamol.ToString());

            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\Random\animal.xml")) // using will help garbage collection, dispose what is not needed anymore automatically 
            {
                serializer.Serialize(tw, enamol);
            }

            enamol = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\Random\animal.xml");

            object obj = deserializer.Deserialize(reader);
            enamol = (Animal)obj;
            reader.Close();

            Console.WriteLine(enamol.ToString());

            List<Animal> animals = new List<Animal>{
                new Animal("Animal1", 35, 55, 1),
                new Animal("Animal2", 65, 45, 2),
                new Animal("Animal3", 75, 35, 3),
                new Animal("Animal4", 45, 25, 4),
                new Animal("Animal5", 25, 15, 5)
            };

            using (Stream fs = new FileStream(@"C:\Users\Random\animals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(List<Animal>));
                serializer1.Serialize(fs, animals);
            }

            animals = null;

            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\Random\animals.xml"))
            {
                animals = (List<Animal>)serializer3.Deserialize(fs2);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}