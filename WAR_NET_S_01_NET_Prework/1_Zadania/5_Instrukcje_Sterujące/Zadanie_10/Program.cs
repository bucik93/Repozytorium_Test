using System;
using System.Text;

namespace Zadanie_10
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.
           
            int points = -3;
                      
            switch (points < 0)
            {
                case true:
                    Console.WriteLine("Ilość punktów jest mniejsza niż zero.");
                    break;
            }
            switch (points > 0 && points < 100)
            {
                case true:
                    break;
            }
            switch (points > 100)
            {
                case true:
                    Console.WriteLine("Ilość punktów jest większa niż 100.");
                    break;
            }
            
            
            if (points >= 0 && points <= 39)
            {
                Console.WriteLine(points + " pkt - ocena niedostateczna");
            }
            
            else if( points >= 40 && points <= 54)
            {
                Console.WriteLine(points + " pkt - ocena dopuszczająca");
            }            else if( points >= 55 && points <= 69)
            {
                Console.WriteLine(points + " pkt - ocena dostateczna");
            }
            else if( points >= 70 && points <= 84)
            {
                Console.WriteLine(points + " pkt - ocena dobra");
            }
            else if (points >= 85 && points <= 98)
            {
                Console.WriteLine(points + " pkt - ocena bardzo dobra");
            }
            else if (points >= 99 && points <= 100)
            {
                Console.WriteLine(points + " pkt - ocena celująca");
            }
            
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}