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

            int resultFor = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(resultFor + i);
            }

            int resultWhile = 0;
            int j = 0;
            while (j < 10)
            {
                j++;
                Console.WriteLine(resultWhile + j);
            }
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}