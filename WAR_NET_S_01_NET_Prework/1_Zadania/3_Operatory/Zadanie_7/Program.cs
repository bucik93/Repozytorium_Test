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

            string a = "Arek";
            string b = "ma";
            string c = "kota";


            string result = a + b + c;
            /* Pomiędzy wyświetlanymi wyrazami brakuje separatora. Zapis powinien wyglądać w ten sposób
               string result = a + " " + b + " " + c; */
            Console.WriteLine(result);

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}