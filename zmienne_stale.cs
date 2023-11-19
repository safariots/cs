using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Deklaracja i inicjalizacja zmiennej
        int liczba = 42;

        // Maniupulacja zmienną ( stosowanie jej w różnych logikach )
        int liczba2 = liczba * 2;

        Console.WriteLine($"Początkowa liczba: {liczba}");
        Console.WriteLine($"Liczba podwojona: {liczba2}");

        // Deklaracja i użycie stałej

        const double PI = 3.14;
        double promien = 5.0;
        double polekola = PI * (promien * promien);

        Console.WriteLine($"Pole koła o promieniu {promien} wynosi {polekola}");

        // Program który oblicza pole pierścienia kołowego
        // Wzór : https://www.dlaucznia.pl/lekcja/matematyka,planimetria,kola-i-okregi,kolo-pole-kola-wycinek-kola

        const double pii = 3.14;
        Console.WriteLine("Wpisz wartość pierwszego promienia: ");
        string promien1 = Console.ReadLine();
        Console.WriteLine("Wpisz wrtość drugiego promienia: ");
        string promien2 = Console.ReadLine();

        if (int.TryParse(promien1, out int promien11) && int.TryParse(promien2, out int promien22))
        {
            double a = (pii * Math.Pow(promien11, 2)) - (pii * Math.Pow(promien22, 2));
            Console.WriteLine($"Pole pierścienia wynosi {a}");
            Thread.Sleep(4000);
        }
        else
        {
            Console.WriteLine("Błąd");
        }
    }
}

