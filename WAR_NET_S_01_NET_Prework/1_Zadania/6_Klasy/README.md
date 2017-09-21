<img alt="Logo" src="http://coderslab.pl/svg/logo-coderslab.svg" width="400">

# Tablice

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

        TUTAJ PRZETESTUJ DZIAŁANIE KLASY

        // Powyżej wpisz swój kod.
        Console.ReadKey();
    }
}

// Poniżej wpisz swój kod klasy.

TUTAJ WPISZ KOD DEKLARACJI KLASY

// Powyżej wpisz swój kod klasy.
```

#### Zadanie 1 - Tworzenie klasy

1. Utwórz klasę o nazwie `Point`.
2. Następnie dodaj do niej dwa pola typu `int` o nazwach `X` i `Y`.
3. Utwórz obiekt klasy point i przypisz pól klasy dowolne liczby.
4. Wyświetl pola klasy `Point` w konsoli za pomocą metody `Console.WriteLine();`.

#### Zadanie 2 - Porównywanie klas

1. Utwórz klasę o nazwie `Human`.
2. Następnie dodaj do niej pole o nazwie `Age`.
3. Utwórz dwa obiekty klasy `Human` o dowolnych nazwach.
4. W oby dwóch obiektach przypisz do pola `Age` liczbę 20.
5. Porównaj dwa obiekty klasy `Human` za pomocą operatora `==` i intrukcji `if else`, tak jak porównywałeś już zwykłe zmienne.
6. Wypisz w konsoli komunikat czy obiekty są równe czy różne.
7. Napisz w komentarzu dlaczego wyszedł taki wynik.

#### Zadanie 3 - Metody

1. Utwórz klasę o nazwie `Car`.
2. Dodaj do klasy pole typu `string` o nazwie `Color`.
3. Dodaj do klasy `Car` metodę `SetRedColor`, która zmieni pole kolor na wartość `red`.
4. Wyświetl wartość pola `Color` w konsoli.

#### Zadanie 4 - Metody i zwracanie danych

1. Utwórz klasę o nazwie `Rectangle`.
2. Dodaj do klasy dwa pola typu int o nazwach `Width` i `Hight`.
3. Uzupełnij pola dowolnymi wartościami od 1 do 1000.
4. Następnie dodaj do klasy metodę `GetArea`, która zwróci pole prostokąta czyli wynik mnożenia pól `Width` i `Height`.
5. Utwórz obiekt klasy.
6. Pobierz wynik działania metody do zmiennej `result`.
7. Wyświetl zmienną `result` w konsoli.

#### Zadanie 5 - Domyślne wartości

1. Utwórz klasę o nazwie `MyClass`
2. Dodaj do klasy cztery pola, kolejno o typach `int`, `string`, `char`, `bool`.
3. Następnie utwórz obiekt klasy, ale przypisuj do pól żadnych wartości.
4. Wyświetl kolejno wszystkie pola w konsoli.
5. Napisz w komentarzu co sądzisz o wynikach.

#### Zadanie 6 - Metody i przyjmowanie parametrów

1. Utwórz klasę o nazwie `Counter`.
2. Dodaj do klasy pole typu `int` o nazwie `Number`.
3. Dodaj do klasy metodę `IncreaseNumber` z parametrem typu `int`, która zwiększy pole `Number` o liczbę podanę w parametrze.
4. Utwórz obiekt klasy Counter.
5. Wywołaj metodę `IncreseNumber`.
6. Następnie wyświetl pole `Number` w konsoli.
