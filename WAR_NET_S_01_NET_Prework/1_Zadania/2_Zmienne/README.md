<img alt="Logo" src="http://coderslab.pl/svg/logo-coderslab.svg" width="400">

# Typy Zmiennych

Pamiętaj aby rozwiązania do zadań umieszczać w odpowiednich projektach do przygotowanych do zadań.
Przykładowo rozwiązanie zadania pierwszego powinno znaleźć się w projekcie `Zadanie_1` w pliku `Program.cs`.
Rozwiązanie zadania drugie w projekcie `Zadanie_2` w pliku `Program.cs` itd.
Rozwiązania zadań umieszczaj między poniższymi linijkami.

```csharp
public static class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Poniżej wpisz swój kod.

        TUTAJ WPISZ ROZWIĄZANIE SWOJEGO ZADANIA.

        // Powyżej wpisz swój kod.
        Console.ReadKey();
    }
}
```

#### Zadanie 1

W pliku `Program.cs` utwórz 5 zmiennych.
Przypisz do zmiennych następujące dane pamiętając, żeby typ zmiennej pasował do typu przypisywanej wartości.

* Liczbę całkowitą.
* Liczbę zmiennoprzecinkową.
* Tekst.
* Wartość logiczną.
* Pojedyńczy znak.

Następnie każdą zmienną wypisz na ekranie konsoli za pomocą metody `Console.WriteLine();`.
Przykład dla jednej zmiennej:
```csharp
int age = 29;
Console.WriteLine(age);
```

Pamiętaj o tworzeniu nazw metodą Camel Case - pierszy wyraz zaczynający się od małej litery, a każdy kolejny od dużej. Nazwy zmiennych powinny być po angielsku. Przykład takich nazw to: `age`, `backgroundColor`, `color`. Nazwa zmiennej powinna mówić co się w niej znajduje.

#### Zadanie 2

1. Utwórz dwie zmienne od dowolnych nazwach, jedną typu `int`, drugą typu `string`.
2. Następnie utwórz 3 zmienną o nazwie `result` i przypisz do niej rezultat dodawania dwóch powyższych zmiennych.
3. Wyświetl zmienną result w konsoli za pomocą metody `Console.WriteLine();` i zobacz rezultat.
