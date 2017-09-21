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


            string[] Fruits = new string[3];
            Fruits[0] = "Pomidor";
            Fruits[1] = "Jabłko";
            Fruits[2] = "Marchewka";
           

            Console.WriteLine(Fruits[0] + ", " + Fruits[1] + ", " + Fruits[2] + ".");
           


            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}