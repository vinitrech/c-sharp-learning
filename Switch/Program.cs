namespace Switch
{
    public class Program
    {

        static void Main(string[] args)
        {

            int age = 123;

            switch (age)
            {
                case 16:
                case 17:
                    Console.WriteLine("Age is 16 or 17");
                    break;
                case 5:
                    Console.WriteLine("Age is 5");
                    break;
                default:
                    Console.WriteLine("Default case");
                    goto OtherStatement; // do not use this
            }

        OtherStatement:
            Console.WriteLine("BAD PRACTICE");
        }
    }
}