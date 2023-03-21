using System;

namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        string ProgamName { get; set; } // Auto generate private field in the background, accessible only from the getter and setter of the property
        private int _program;

        public int Program
        { // treating data before assignment or return
            get
            {
                return _program;
            }

            set
            {
                _program = value;
            }
        }
    }
}