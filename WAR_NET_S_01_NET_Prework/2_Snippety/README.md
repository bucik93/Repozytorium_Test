<img alt="Logo" src="http://coderslab.pl/svg/logo-coderslab.svg" width="400">

# NET Prework - Snippety
> Krótkie kawałki kodu, które pokazują zależności, rozwiązują popularne problemy oraz pokazują jak używać niektórych funkcji.

#### 1. Zasady przy tworzeniu nazw zmiennych.


#### 2. Komentarze w C#.
```csharp
// Komentarz jednolinijkowy zaczyny się od dwóch znaków prawego ukośnika i trwa do końca linijki.

/*
    Drugi rodzaj komentarza to komentarz wielolinijkowy.
    Zaczyna się od prawego ukońnika i znaku gwiazdki.
    Kończy się znakiem gwiazdki i prawego ukośnika.
*/
```

#### 3. Czy zmienne typu string można dodawać.

Nie, znak plusa w przypadku zmiennych typu `string` pełni funkcja znaku konkatenacji (łączenia ze sobą wyrażeń) i służy do łączenia tekstu.
```csharp
string firstName = "Jan";
string lastName = "Kowalski";

string fullName = firstName + " " + lastName;
```

#### 4. Czy typ int ma jakieś ograniczenia co do wielkości przechowywanej liczby.

Tak, typ integer może przechowywać liczby od -2147483648 do 2147483647.

#### 5. Czy typ string ma jakieś ograniczenia co do wielkości przechowywanego napisu.

Tak i nie, przechowywany napis może być tak duży na ile pozwala pamięć komputera.

#### 6. Wyświetlenie tekstu w tej samej linii.

Do wyświetlania tekstu w tej samej linii służy metoda Console.Write();

Przykład użyty w pętli
```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
foreach(int n in numbers)
{
    Console.Write(n + " "); // Dodałem pusty znak spacji...
    // ... żeby były odstępy między znakami.
}
// Konsola wyświetli: 1 2 3 4 5 6
```

#### 7. Jak wyświetlić znak nowej linii bez wyświetlania tekstu.

Jeśli chcemy przejść do nowego wiersza w konsoli bez wypisywania żadnego tekstu możemy użyć metody `Console.WriteLine();` nie podając w parametrze żadanej zmiennej, ani tekstu.

Zobaczmy przykład:
```csharp
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
foreach(int n in numbers)
{
    Console.Write(n);
    Console.WriteLine();
}
// Konsola wyświetli:
// 1
// 2
// 3
// 4
// 5
// 6
```

#### 8. Instrukcja If else if

Możemy rozbudować instrukcję if else o kolejne intrukcję else if.

```cs
if (a < b)
{
    Console.WriteLine("a mniejsze od b");
}
else if (a > b) 
{
    Console.WriteLine("b większe od a")
}
else
{
    Console.WriteLine("a jest równe b");
}
```

Takich kolejnych istrukcji else if może dodawać w nieskończoność, oczwiście jest to niezalecane, aby było ich więcej niż kilka.

#### 9. Utworzenie tablicy o podanym rozmiarze
Tworząc tablicę musimy podać jej wielkość. Robimy to wpisując liczbę w nawiasy kwadratowe.
```cs
string[] array = new string[10];
```

#### 10. Sprawdzanie rozmiaru tablicy
W chwili w której mamy stwozoną tablicę możemy odpytać się o jej długość. Robimy to wywołując jej parametr `Length`. 
```cs
// Wcześniej mamy przygotowaną tablicę o nazwie array.
int length = array.Length;
```

#### 11. Dodawanie elemntu do tablicy
Żeby włożyć element do tablicy musimy przypisać do niej wartość podobnie jak w przypadku normalnych zmiennych. Trzeba tylko podać indeks "komórki" w której wartość ma się znaleźć. 
**Pamiętaj że komórki w tablicy indeksowane są od 0**
```cs
string[] array = new string[10];
array[0] = "Text";
```

#### 12. Tworzenie nowej listy
Żeby stworzyć nową listę musimy stworzyć nowy obiekt klasy `List`. Musimy też podać (w ostrych nawiasach) typ danych które będą trzymane w liście. Lity automactycznie zmieniają swoją wielkośc więc nie musimy jej podawać przy ich tworzeniu. 
```cs
List<string> list = new List<string>();
```

#### 13. Dodawanie i usuwanie elementów z listy
Mając stworzoną już listę możemy dowolnie wkładać i wyciągać z niej elementy. Żeby dodać element używamy metody `Add(el)`. Metoda ta przyjmuje jeden parametr - element który zostanie dodany do listy.  
Żeby usunąć element z listy używamy metody `Remove(el)`. Metoda ta przyjmuje jeden parametr - element który zostanie usunięty z listy. Jeżeli podanego eleentu nie ma w liście to metoda nic nie zrobi. Jeżeli jest więcej niż jeden taki element (np. w liście mamy kilka takich samych napisów) to usunięte zostanie tylko pierwsze powtórzenie, reszta zostanie bez zmian.
```cs
List<string> myList = new List<string>();
myList.Add("Item 1");
myList.Remove("Item 1");
```
#### 14. Sprawdzanie rozmiaru listy
W chwili w której mamy stwozoną listę możemy odpytać się o jej długość. Robimy to wywołując jej parametr `Count`. 
```cs
// Wcześniej mamy przygotowaną listę o nazwie myList.
int listLength = myList.Count;
```

#### 15. Przeglądanie kolekcji w pętli for
Jeżeli chcemy przejść i zrobic coś z każdym elementem listy (albo innej kolekcji) możemy do tego użyć pętli `for`. Musimy wtedy przeiterować po wszsytkich liczbach od 0 do długości listy i wyciągnąć w pętli element znajdujący się na i-tej pozycji.  
```cs
List<string> myList = new List<string>();
...
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(myList[i]);
}
```

#### 16. Przeglądanie kolekcji w pętli foreach
Jeżeli chcemy przejść i zrobic coś z każdym elementem listy (albo innej kolekcji) możemy do tego użyć pętli `foreach`. W tej pętli podajemy nazwę kolekcji którą chcemy przejrzeć i nazwę zmiennej w której mają się znajdowacć kolejne elementy z naszej koleckji (każdy element ma swój obrót pętli).  
Musimy pamiętać żeby zmienna deklarowana w pętlu `foreach` miała taki sam typ danych jaki trzymamy w liscie. 
```cs
List<int> myList = new List<int>();
foreach (int item in list)
{
    Console.WriteLine(itel);
}
```

#### 17. Deklaracja klasy
Deklaracja nowej klasy o nazwie `MyClass`:
```cs
public class MyClass
{
    public int X = 10;
    public int Y = 20;
}
```

#### 18. Tworzenie obiektu klasy
Tworzenie obiektu naszej klasy. Pamiętaj o słowie kluczowym `new`:
```cs
MyClass myClass = new MyClass();
```

#### 19. Deklaracja i użycie klasy
Deklaracja nowej klasy i użycie jej w głównej metodzie naszego programu: 
```cs
namespace ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.X = 50;

            Console.WriteLine(myClass.X);
            Console.WriteLine(myClass.Y);

            Console.ReadKey();
        }
    }

    public class MyClass
    {
        public int X = 10;
        public int Y = 20;
    }
}
```

#### 20. Losowanie liczby
W C# możemy łatwo wygenerować losową liczbę. Używamy do tego obliektu klasy `Random` i metody `Next()`. Pamiętaj że obiek musisz wcześniej stworzyć. 
```cs
Random random = new Random();
int next = random.Next(1, 30);
```
Możesz wygenerować też losową liczbe z zakresu od 0 do podanej liczby. Jak to zrobić możesz zobaczyć w dokumentacji klasy `Random`: https://msdn.microsoft.com/pl-pl/library/system.random(v=vs.110).aspx#Anchor_3
