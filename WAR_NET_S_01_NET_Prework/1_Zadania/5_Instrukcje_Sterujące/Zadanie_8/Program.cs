using System;
using System.Text;

namespace Zadanie_8
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.
            int n = 5;
            int i, j, k;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; ++j)
                    Console.Write("*");

                for (k = n - i; k >= 1; k--)
                    Console.Write(j++);

                Console.Write("\n");
            }

            /*Rozwiązanie dla n = 3
            int n = 3;
            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; ++j)
                    Console.Write("*");

                for (k = n - i; k >= 1; k--)
                    Console.Write(j++);

                Console.Write("\n");
            }
            */

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}