using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynxenumerableExample1
{
    class Repository
    {
        private string[] data = new[] {"Tom", "Mark", "Alex", "Ivan", "Misha"};

        public async IAsyncEnumerable<string> GetDataAsync()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Получаем {i+1} элемент.");
                await Task.Delay(1000);
                yield return data[i];
            }
        }
    }
    
    class Program
    {
        static async Task Main(string[] args)
        {
            Repository repo = new Repository();
            IAsyncEnumerable<string> data = repo.GetDataAsync();
            await foreach (var name in data)
            {
                Console.WriteLine(name);
            }
        }
    }
}