using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Counter{Value = 43};
            var c2 = new Counter {Value = 23};

            var c3 = c1 + c2;
            Console.WriteLine(c3.Value);
        }
    }

    class Counter
    {
        public int Value { set; get; }

        static Counter()
        {
            Console.WriteLine("First created object");
        }

        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter {Value = c1.Value + c2.Value};
        }
    }
}