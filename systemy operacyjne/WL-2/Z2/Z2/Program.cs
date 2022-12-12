using System;
using System.Threading;

namespace Z2
{
    class Program
    {
        // Zmienne dostępne dla wszystkich wątków
        static int adresat = 0;
        static string wiadomosc = "";

        // Metoda uruchamiana przez każdy wątek
        static void Watek(object numerID)
        {
            // Pętla wątku
            while (true)
            {
                // Sprawdzenie, czy dany wątek jest adresatem wiadomości
                if (adresat == (int)numerID)
                {
                    // Wypisanie wiadomości i ustawienie nowej wiadomości i adresata
                    Console.WriteLine($"Wątek {numerID}: otrzymałem wiadomość: {wiadomosc}");
                    wiadomosc = $"Witaj, jestem wątkiem {numerID}";
                    adresat = new Random().Next(6); // Losowanie adresata spośród 6 wątków
                }

                // Losowe zasypianie wątku na od 10 do 30 milisekund
                Thread.Sleep(new Random().Next(10, 30));
            }
        }

        static void Main(string[] args)
        {
            // Uruchomienie 6 wątków
            for (int i = 0; i < 6; i++)
            {
                new Thread(Watek).Start(i);
            }

            // Pętla wątku głównego
            while (true)
            {
                // Ustawienie losowego adresata i wiadomości
                adresat = new Random().Next(6);
                wiadomosc = $"Witaj, jestem wątkiem {Thread.CurrentThread.ManagedThreadId}";

                // Zasypianie wątku głównego na od 10 do 30 milisekund
                Thread.Sleep(new Random().Next(10, 30));
            }

            Console.ReadKey();
        }
    }
}
