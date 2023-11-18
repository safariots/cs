using System;

class Program()
{
    static void Main()
    {
        // instrukcja if

        int liczba = 10;

        if (liczba > 0)
        {
            Console.WriteLine("Liczba jest dodatnia");
        }

        // instrukcja else if (dodatkowy warunek kiedy if jest nie spełnione)

        int liczba1 = 0;

        if (liczba1 > 0)
        {
            Console.WriteLine("Liczba jest dodatnia");
        }
        else if (liczba1 > 0)
        {
            Console.WriteLine("Liczba jest ujemna");
        }
        else
        {
            Console.WriteLine("Liczba jest równa zeru");
        }

        // insturkcja switch umożliwia porównywanie wielu wartości

        int dayOfWeek = 3;

        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Poniedziałek");
                break;
            case 2:
                Console.WriteLine("Wtorek");
                break;
            case 3:
                Console.WriteLine("Środa");
                break;

            // inne przypadki
            default:
                Console.WriteLine("Nieznany dzień tygodnia");
                break;
        }

        // && - AND, || - OR, ! - NOT
        int x = 5;
        int y = 10;

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Obie liczby są dodatnie.");
        }
        if (x > 0 || y > 0)
        {
            Console.WriteLine("Co najmniej jedna z liczb jest dodatnia.");
        }
        if (!(x < 0))
        {
            Console.WriteLine("x nie jest ujemne.");
        }
    }  
}


