using System;

namespace generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 7;
            var y = 234;
            swap(ref x, ref y);
            Console.WriteLine($"x = {x}; y = {y}");

            var str1 = "hello";
            var str2 = "world";
            swap(ref str1, ref str2);
            Console.WriteLine($"str1 : {str1}; str2 : {str2}");
        }

        public static void swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}