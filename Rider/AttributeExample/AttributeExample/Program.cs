using System;

namespace AttributeExample
{
    class AgeValidationAttribute : Attribute
    {
        public int Age { get; set; }
        public AgeValidationAttribute(){}

        public AgeValidationAttribute(int age)
        {
            Age = age;
        }
    }

    [AgeValidation(18)]
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom", 15);
            User bob = new User("Bob", 35);
            bool tomIsValid = ValidateUser(tom);
            bool bobIsValid = ValidateUser(bob);
            
            Console.WriteLine($"Реультат валидации Тома: {tomIsValid}");
            Console.WriteLine($"Реультат валидации Боба: {bobIsValid}");

        }

        static bool ValidateUser(User user)
        {
            Type type = typeof(User);
            object[] attrs = type.GetCustomAttributes(false);

            foreach (AgeValidationAttribute attr in attrs)
            {
                return user.Age >= attr.Age;
            }

            return true;
        }
    }
}