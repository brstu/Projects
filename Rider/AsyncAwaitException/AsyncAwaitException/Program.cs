using System;
using System.Threading.Tasks;

namespace AsyncAwaitException
{
    class Program
    {
        static void Factorial(int n)
        {
            if (n < 1)
                throw new Exception($"{n} : число не должно быть меньше 1");
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }
         
        static async void FactorialAsync(int n)
        {
            Task task = null;
            try
            {
                task = Task.Run(()=>Factorial(n));
                await task;
            }
            catch (Exception ex)
            {
                Console.WriteLine(task.Exception.InnerException.Message);
                Console.WriteLine($"IsFaulted: {task.IsFaulted}");
            }
        }
 
        static void Main(string[] args)
        {
            FactorialAsync(7);
            FactorialAsync(-4);
            FactorialAsync(6);

            Console.Read();
        }
    }
}