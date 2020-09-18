using System;

namespace delegate1
{
    class Program
    {
        delegate void Message();
        
        static void Main(string[] args)
        {
            Message mes;
            if (DateTime.Now.Hour<12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvening;
            }

            mes();
        }

        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
    }
}