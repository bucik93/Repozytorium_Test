using System;
using System.Text;

namespace Zadanie_6
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            int[] Numbers = new int[10];
            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;
            Numbers[3] = 4;
            Numbers[4] = 5;
            Numbers[5] = 6;
            Numbers[6] = 7;
            Numbers[7] = 8;
            Numbers[8] = 9;
            Numbers[9] = 10;


            for (int i = 0; i < 10; i++)
            {
                Numbers[i] = i + 1;
                Console.WriteLine(Numbers[0] + i);

            }

            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}