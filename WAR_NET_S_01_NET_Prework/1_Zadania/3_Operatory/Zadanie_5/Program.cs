using System;
using System.Text;

namespace Zadanie_5
{
    public static class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Poniżej wpisz swój kod.

            int a = 10;
            int b = 10;
            int resultA = ++a;
            int resultB = b++;

            Console.WriteLine(resultA);
            /* Wynik będzie 11. Program w pierwszej kolejności zwiększy wartość zmiennej a o 1.
               W kolejnym kroku pobierze już zwiększoną wartość. Na końcu przypiszę zwiększoną wartość                do zmiennej resultA. */
            Console.WriteLine(resultB);
            /* Wynik będzie 10. Program w pierwszej kolejności pobierze wartość zmiennej b.
               W kolejnym kroku przypiszę tą wartość do zmiennej resultB. Na końcu zwiększy wartość 
               zmiennej b o 1 */

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}