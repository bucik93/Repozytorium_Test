using System;
using System.Text;

namespace Zadanie_4
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            int a1 = a % 2;
            int b1 = b % 2;
            int c1 = c % 2;
            int d1 = d % 2;

            Console.WriteLine(a1);
            // Wynik będzie 1, bo 1 / 2 = 1 i zostaje 1 reszty z dzielenia
            Console.WriteLine(b1);
            // Wynik będzie 0, bo 2 / 2 = 1, nie zostaje żadna reszta z dzielenia
            Console.WriteLine(c1);
            Console.WriteLine(d1);




            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}