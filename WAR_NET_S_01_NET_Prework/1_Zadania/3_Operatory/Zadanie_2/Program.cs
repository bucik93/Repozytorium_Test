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

            int a = 2;
            int b = 4;
            int c = 6;
            int result = (a + 5 * b * c);
            /* Wynik działania to 122. Liczba 5 została pomnożona w pierwszej kolejności przez b czyli 4 następnie 
               pomnożona przez c czyli 6 a na końcu została dodana liczba a czyli 2. Priorytety operatorów 
               artmetrycznych są wykonywane zgodnie z kolejnością znaną z matematyki. */

            int result2 = (a + 5) * b * c;
            /* Wynik działania to 168. Za pomocą nawiasów nadałem priorytet operatorowi dodawania, którego 
               wynik został pomnożony przez 4 a potem przez 6. */

            Console.WriteLine(result);
            Console.WriteLine(result2);

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}