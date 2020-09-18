using System;
using System.Linq;

namespace PLINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] {-2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8};
            var factorials = from number in numbers.AsParallel().AsOrdered()
                where number > 0
                select Factorial(number);

            foreach (var i in factorials)
            {
                Console.WriteLine(i);
            }
        }

        static int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i < n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}