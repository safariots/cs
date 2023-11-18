using System;
using System.ComponentModel.Design;

class Program
{
    static void Dodawanie()
    {
        // Dodawanie
        Console.Write("Liczba pierwsza: ");
        string liczba1 = Console.ReadLine();

        Console.Write("Liczba druga: ");
        string liczba2 = Console.ReadLine();

        if (int.TryParse(liczba1, out int liczba11) && int.TryParse(liczba2, out int liczba22))
        {
            Console.WriteLine($"{liczba11} + {liczba22} = {liczba11 + liczba22}");
            Thread.Sleep(2000);
            
        }
        else
        {
            Console.WriteLine("To nie jest liczba!!!");
            Thread.Sleep(2000);
        }
    }

    static void odejmowanie()
    {
        // odejmowanie
        Console.Write("Liczba pierwsza: ");
        string liczba1 = Console.ReadLine();

        Console.Write("Liczba druga: ");
        string liczba2 = Console.ReadLine();

        if (int.TryParse(liczba1, out int liczba11) && int.TryParse(liczba2, out int liczba22))
        {
            Console.WriteLine($"{liczba11} - {liczba22} = {liczba11 - liczba22}");
            Thread.Sleep(2000);

        }
        else
        {
            Console.WriteLine("To nie jest liczba!!!");
            Thread.Sleep(2000);
        }
    }

    static void mnozenie()
    {
        // mnozenie
        Console.Write("Liczba pierwsza: ");
        string liczba1 = Console.ReadLine();

        Console.Write("Liczba druga: ");
        string liczba2 = Console.ReadLine();

        if (int.TryParse(liczba1, out int liczba11) && int.TryParse(liczba2, out int liczba22))
        {
            Console.WriteLine($"{liczba11} * {liczba22} = {liczba11 * liczba22}");
            Thread.Sleep(2000);

        }
        else
        {
            Console.WriteLine("To nie jest liczba!!!");
            Thread.Sleep(2000);
        }
    }

    static void dzielenie()
    {
        // dzielenie
        Console.Write("Liczba pierwsza: ");
        string liczba1 = Console.ReadLine();

        Console.Write("Liczba druga: ");
        string liczba2 = Console.ReadLine();

        if (int.TryParse(liczba1, out int liczba11) && int.TryParse(liczba2, out int liczba22))
        {
            Console.WriteLine($"{liczba11} / {liczba22} = {liczba11 / liczba22}");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("To nie jest liczba!!!");
            Thread.Sleep(2000);
        }
    }

    static void potegowanie()
    {
        Console.Write("Wprowadź podstawe: ");
        string podstawa = Console.ReadLine();

        Console.Write("Wprowadź wykładnik: ");
        string wykładnik = Console.ReadLine();

        if (int.TryParse(podstawa, out int pod) && int.TryParse(wykładnik, out int wyk))
        {
            double wynik = Math.Pow(pod, wyk);

            Console.WriteLine($"Wynik potęgowania {pod} do potęgi {wyk} wynosi: {wynik}");
        }
    }

    static void Main()
    {
        Console.WriteLine("Kalkulator | naukacs");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        Console.WriteLine("5. Potęgowanie");
        Console.WriteLine("Wybierz opcje (1 - 5): ");
        string wybor = Console.ReadLine();

        switch (wybor)
        {
            case "1":
                Dodawanie();
                break;
            case "2":
                odejmowanie();
                break;
            case "3":
                mnozenie();
                break;
            case "4":
                dzielenie();
                break;
            case "5":
                potegowanie();
                break;
        }
    }
}