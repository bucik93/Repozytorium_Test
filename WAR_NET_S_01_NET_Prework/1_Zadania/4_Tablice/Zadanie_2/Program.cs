using System;
using System.Text;

namespace Zadanie_2
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            string[] Colors = new string[4];
            Colors[0] = "Mój pierwszy kolor to: niebieski.";
            Colors[1] = "Mój drugi kolor to: czarny.";
            Colors[2] = "Mój trzeci kolor to: zielony.";
            Colors[3] = "Mój ostatni kolor to: czerwony.";

            Console.WriteLine(Colors[0]);
            Console.WriteLine(Colors[1]);
            Console.WriteLine(Colors[2]);
            Console.WriteLine(Colors[3]);

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}