using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number");
            int x;
            var input = Console.ReadLine();
            if (int.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Square of x: "+x);
            }
            else
            {
                Console.WriteLine("incorrect input");
            }

            Console.ReadLine();
        }
    }
}