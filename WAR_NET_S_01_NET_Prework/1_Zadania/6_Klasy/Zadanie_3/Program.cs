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

            Car myCar = new Car();
            myCar.SetRedColor();
            Console.WriteLine(myCar.Color);

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }

    // Poniżej wpisz swój kod klasy.

    public class Car
    {
        public string Color;
        public void SetRedColor()
        {
            Color = "red";
        }

    }

    // Powyżej wpisz swój kod klasy.
}