using System;
using System.Text;

namespace Zadanie_5
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            int n = 10;
            for (n = 0; n < 11; n++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n + " - liczba parzysta");
                }
                else
                {
                    Console.WriteLine(n + " - liczba nieparzysta");
                }
            }         
          
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}