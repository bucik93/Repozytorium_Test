using System;
using System.Text;

namespace Zadanie_7
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            int[] Numbers = new int[10];
            Numbers[0] = 0;
            Numbers[1] = 1;
            Numbers[2] = 2;
            Numbers[3] = 3;
            Numbers[4] = 4;
            Numbers[5] = 5;
            Numbers[6] = 6;
            Numbers[7] = 7;
            Numbers[8] = 8;
            Numbers[9] = 9;


            for (int i = 0; i < 10; i++)
            {
                Numbers[i] = i - 0;
                
                Console.WriteLine("To jest liczba: "+ Numbers[i]);
              
            }

            foreach (int number in Numbers)
            {
                Console.WriteLine("To jest liczba: " + number);
            }
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}