using System;

namespace exception1
{
    class PersonException : ArgumentException
    {
        public int Value { get; }

        public PersonException(string message, int value) : base(message)
        {
            Value = value;
        }
    }

    class Person
    {
        public string Name { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new PersonException("age less then 18", value);
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person {Name = "Tom", Age = 12};
            }
            catch (PersonException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine($"Incorrect value: {e.Value}");
            }
        }
    }
}