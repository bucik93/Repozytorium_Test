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

            Counter counter = new Counter();
            counter.IncreaseNumber(12);
            Console.WriteLine(counter.Number);
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }

    // Poniżej wpisz swój kod klasy.
    
    public class Counter
    {
        public int Number;
        public int IncreaseNumber(int a)
        {
            return Number = Number + a;
        }
    }
    // Powyżej wpisz swój kod klasy.
}