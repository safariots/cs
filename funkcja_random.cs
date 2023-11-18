using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int losowa = random.Next(1, 101);

        Console.WriteLine("Zgadnij liczbę (1 - 100): ");

        while (true)
        {
            string liczba = Console.ReadLine();

            if (int.TryParse(liczba, out int zgadywana))
            {
                if (zgadywana < 1 || zgadywana > 100)
                {
                    Console.WriteLine("Podaj liczbę z zakresu 1-100.");
                }
                else if (zgadywana == losowa)
                {
                    Console.WriteLine("Gratulacje, zgadłeś!");
                    break;
                }
                else if (zgadywana < losowa)
                {
                    Console.WriteLine("Za mało, spróbuj ponownie.");
                }
                else
                {
                    Console.WriteLine("Za dużo, spróbuj ponownie.");
                }
            }
            else
            {
                Console.WriteLine("Podaj poprawną liczbę.");
            }
        }
    }
}
