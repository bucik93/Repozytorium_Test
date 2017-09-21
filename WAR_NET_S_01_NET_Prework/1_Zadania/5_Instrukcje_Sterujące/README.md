<img alt="Logo" src="http://coderslab.pl/svg/logo-coderslab.svg" width="400">

# Instrukcje Sterujące

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

#### Zadanie 1 - Znajdź większą liczbę

1. Utwórz dwie zmienne typu `int` o nazwach `n1` i `n2`. Przypisz do nich dwie różne liczby.
2. Za pomocą intrukcji `if else` porównaj wartości tych zmiennych i wypisz w konsoli, która z liczb jest większa.
3. Do wypisania tekstu w konsoli użyj metody `Console.WriteLine();`.
4. Tekst musi być według wzoru `Większa liczba to: `.

#### Zadanie 2 - Pętla

1. Stwórz pętle, która 10 razy wypisze w konsoli `C#`.
2. Napisz to zarówno przy użyciu pętli `for` jak i przy użyciu pętli `while`.
3. W sumie w konsoli wyraz `C#` pojawi się 20 razy.

#### Zadanie 3 - Pętla i liczby

1. Stwórz pętle, która wypisze w konsoli liczby od 0 do 50.
2. Napisz to zarówno przy użyciu pętli `for` jak i przy użyciu pętli `while`.
3. W sumie w konsoli powinno pojawić się 102 liczby.

#### Zadanie 4 - Dodawanie do siebie kolejnych liczb

1. Stwórz zmienną o nazwie `resultFor` i przypisz do niej wartość `0`.
2. Następnie stwórz pętle `for`, która doda do zmiennej `resultFor` liczby od 1 do 10.
3. Pętla co każdą iterację powinna dodawać do zmiennej kolejną liczbę 1, 2 itp.
4. Stwórz zmienną `resultWhile` i powtórz wszyskie kroki w pętli przey użyciu pętli `while`.

#### Zadanie 5 - Wypisz liczby

1. Stwórz zmienną o nazwie `n` i przypisz do niej watość 10.
2. Następnie wypisz na ekranie wszystkie liczby od `0` do `n`.
3. Przy każdej liczbie napisz czy jest ona parzysta czy nie.

Wzór
```csharp
0 - parzysta
1 - nieparzysta
2 - parzysta
itd...
```

Podpowiedź: Jak sprawdzić czy liczba jest parzysta czy nie, wystarczy obliczyć jej resztę z dzielenia przez 2, jeżeli wynik jest równy 0 to liczba będzie parzysta, w przeciwnym przypadku liczba będzie nieparzysta.

#### Zadanie 6 - Pętle i tablice z liczbami

1. Stwórz tablicę z 10 liczbami.
2. Następnie wypisz w konsoli wszyskie liczby przy użyciu pętli `for` i przy użyciu `foreach`.

#### Zadanie 7 - Pętle i tablice z tekstem

1. Stwórz tablicę z 10 liczbami.
2. Nastepnie wypisz w konsoli 10 razy tekst `To jest liczba: ` wraz z kolejnymi liczbami.
3. Wykonaj zadanie przy użyciu pętli `for` i przy użyciu pętli `foreach`.

Wzór
```csharp
To jest liczba: 0
To jest liczba: 1
```

#### Zadanie 8 - Gwiazki i liczby

1. Stwórz zmienną o nazwie `n` i przypisz do nie wartość 5.
2. Następnie napisz skrypt, który wypisze w konsoli schemat przedstawiony poniżej.

Schemat dla `n = 5`.
```
* 2 3 4 5
* * 3 4 5
* * * 4 5
* * * * 5
* * * * *
```

Schemat dla `n = 3`.
```
* 2 3
* * 3
* * *
```

#### Zadanie 9 - Tylko gwiazki

1. Stwórz zmienną o nazwie `n` i przypisz do nie wartość 5.
2. Następnie napisz skrypt, który wypisze w konsoli schemat przedstawiony poniżej.

Schemat dla `n = 5`.
```
*
* *
* * *
* * * *
* * * * *
```

Schemat dla `n = 3`.
```
*
* *
* * *
```

#### Zadanie 10 - Oceny

1. Utwórz zmienną point w której będą przechowywane wyniki testu.
2. Następnie przypisz do zmiennej points dowolną liczbę.
3. Utwórz kod, który wyświetli w konsoli ocenę z testu według poniższego schematu.
* 0 - 39 pkt - ocena niedostateczna
* 40 - 54 pkt - ocena dopuszczająca
* 55 - 69 pkt - ocena dostateczna
* 70 - 84 pkt - ocena dobra
* 85 - 98 pkt - ocena bardzo dobra
* 99 - 100 pkt - ocena celująca
4. Pamiętaj o sprawdzeniu czy zmienna points jest w mniejsza od `0` lub większa od `100` i wyświetl odpowiedni komunikat o treści `Ilość punktów jest mniejsza niż zero.` lub odpowiednio `Ilość punktów jest większa niż 100`.
5. Do rozwiązania zadania użyj konstrukcji `if else` i `switch`.
6. Pamiętaj, że konstrukcje `if else` możesz zagnieżdżać lub możesz skorzystać z bardziej rozbudowanej wersji `if else if`, więcej w snippetach.
