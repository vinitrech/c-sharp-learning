namespace Models
{
    public class ExampleModel
    {
        public string Message { get; set; }

        public ExampleModel(string message)
        {
            Message = message;
        }

        public void PrintMessage()
        {
            Console.WriteLine(Message);
        }
    }
}