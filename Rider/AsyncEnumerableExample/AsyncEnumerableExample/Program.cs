using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncEnumerableExample
{
    class Program
    {
        public static async IAsyncEnumerable<int> GetNumberAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        static async Task Main(string[] args)
        {
            await foreach (var number in GetNumberAsync())
            {
                Console.WriteLine(number);
            }
        }
    }
}