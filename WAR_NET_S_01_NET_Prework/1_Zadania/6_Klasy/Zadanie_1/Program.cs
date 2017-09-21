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

            Point myPoint = new Point();

            Console.WriteLine(myPoint.X);
            Console.WriteLine(myPoint.Y);
            
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }

    // Poniżej wpisz swój kod klasy.

    public class Point
    {
        public int X = 2;
        public int Y = 3;
    }
           
    // Powyżej wpisz swój kod klasy.
}