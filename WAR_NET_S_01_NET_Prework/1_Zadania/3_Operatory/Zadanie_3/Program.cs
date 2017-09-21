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

            int a = 7;
            int b = 3;

            int result1 = a + b;
            int result2 = a - b;
            int result3 = a * b;
            int result4 = a / b;
            int result5 = a % b;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}