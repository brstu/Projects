using System;

namespace interface1
{
    internal interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }

    internal interface IClient
    {
        string Name { get; set; }
    }

    internal class Client : IAccount,IClient
    {
        public Client(string name, int sum)
        {
            Name = name;
            CurrentSum = sum;
        }
        public int CurrentSum { get; private set; }
        public void Put(int sum) => CurrentSum += sum;

        public void Withdraw(int sum)
        {
            if (CurrentSum>=sum)
            {
                CurrentSum -= sum;
            }
        }

        public string Name { get; set; }
    }

    internal static class Program
    {
        private static void Main(string[] args)
        {
            var client = new Client("Tom", 200);
            client.Put(30);
            Console.WriteLine(client.CurrentSum);
            client.Withdraw(100);
            Console.WriteLine(client.CurrentSum);
        }
    }
}