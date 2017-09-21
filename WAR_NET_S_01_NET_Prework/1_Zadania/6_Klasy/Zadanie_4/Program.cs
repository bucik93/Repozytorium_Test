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
     
            Rectangle rec = new Rectangle();
            //Console.WriteLine(rec.GetArea());
            rec.result = rec.GetArea();
            Console.WriteLine(rec.result);
            
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }

    // Poniżej wpisz swój kod klasy.
    
    public class Rectangle
    {
        public int Width = 200;
        public int Hight = 400;
        public int result;
        public int GetArea()
        {         
          return Width * Hight;
        }
    }

    // Powyżej wpisz swój kod klasy.
}