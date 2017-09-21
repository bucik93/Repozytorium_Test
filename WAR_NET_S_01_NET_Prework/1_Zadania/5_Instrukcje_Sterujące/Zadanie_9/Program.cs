using System;
using System.Text;

namespace Zadanie_9
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= 1 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //schemat dla n=3
            //int n = 3;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 0; j <= 1 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}