using System;
using System.Text;

namespace Zadanie_3
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(i);
            }

            int j = -1;

            while(j < 50)
            {
                j++;
                Console.WriteLine(j);
            }
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}