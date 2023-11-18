using System;
using System.Threading;

class prostyprogram
{
    static void Main()
    {
        // Pobieranie informacji dla zmiennej imie
        Console.Write("Podaj swoje imię: ");
        string imie = Console.ReadLine();

        // Wyświetlanie
        Console.WriteLine($"Witaj, {imie}!");
        Wiek();
    }
    static void Wiek()
    {
        Console.Write("Podaj swój wiek: ");
        string wiekTekst = Console.ReadLine();

        if (int.TryParse(wiekTekst, out int wiek))
        {
            Console.WriteLine($"Twój wiek: {wiek}");
            Thread.Sleep(5000);
            lata();
        }
        else
        {
            Console.WriteLine("To nie jest wiek!!!");
            Thread.Sleep(5000);
            lata();
        }
    }
    static void lata()
    {
        Console.Write("Podaj swój wiek: ");
        string lat = Console.ReadLine();
        int program;
        if (int.TryParse(lat, out program))
        {
           if (program >= 18)
            {
                Console.WriteLine("Jesteś Pełnoletni.");
            }
           else
            {
                Console.WriteLine("Nie jesteś pełnoletni");
            }
            Thread.Sleep(5000);
        }   
    }
}
