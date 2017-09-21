using System;
using System.Text;

namespace Zadanie_1
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            int n1 = 1;
            int n2 = 3;

            if (n2 > n1)
            {
                Console.WriteLine("Większa liczba to: " + n2);
            }
            else
            {
                Console.WriteLine("Mniejsza liczba to:" + n1);
            }
            
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}