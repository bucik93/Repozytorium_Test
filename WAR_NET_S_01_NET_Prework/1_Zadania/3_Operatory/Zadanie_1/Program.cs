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

            bool isAdmin = true;
            bool isCustomer = false;
            bool result1 = (isAdmin == isCustomer);
            bool result2 = !(isAdmin == isCustomer);
            //można również w taki sposób zapisać bool result2 = (!result1);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }
}