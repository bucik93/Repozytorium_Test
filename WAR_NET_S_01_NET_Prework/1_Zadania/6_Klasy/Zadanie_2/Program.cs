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

            Human human1 = new Human();
            Human human2 = new Human();
            human1.Age = 20;
            human2.Age = 20;
            if (human1 == human2)
            {
                Console.WriteLine("Obiekty są równe");
            }
            else
            {
                Console.WriteLine("Obiekty są różne");
            }
            // Powyżej wpisz swój kod.
            Console.ReadKey();
        }
    }

    /* Tworząc obiekty klasy, każdy obiekt klasy jest od siebie niezależny, może posiadać inne dane, 
       Każda instancja klasy jest od siebie niezależna. */

    // Poniżej wpisz swój kod klasy.

    public class Human
    {
        public int Age;
    }

    // Powyżej wpisz swój kod klasy.
}