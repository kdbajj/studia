using System;
using System.Threading;

/*Zadanie 1
 * W funkcji main należy wywołać funkcję print squares, wypisuje kwadraty kolejnych liczb naturalnych od 1 do 100.
 * Poniżej tej funkcji należy wypisać 100 razy "Hello my friend". Program ma zakończyć się po naciśnięciu esc.
 * 
Zadanie 2
dorzucamy nowy wątek w wątku głównym (wywołana w main ale nowy wątek)

Zadanie 3
join

Zadanie 4
Nowy wątek.

Zadanie 5
Uśpić wątek na 1000 milisekund.

Zadanie 6

Uruchomić wątek jeden po drugim
*/


namespace lista_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thr = new Thread(new ThreadStart(PrintSquares));
            
            thr.Join();
            thr.Start();

            Thread thr2 = new Thread(new ThreadStart(PrintQubes));
            thr2.Join();
            thr2.Start();


            Thread.Sleep(200);
            Thread.Sleep(2000);


            PrintHelloMyFriend();

            Console.ReadKey();
        }
        public static void PrintSquares()
        {
            
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Kwadrat " + i + " to:  " + i*i);
            }
           
        }

        public static void PrintHelloMyFriend()
        {
            for(int i = 0; i < 100; i++)
            Console.WriteLine(i + ". Hello my friend!");
            while
            (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }

        public static void PrintQubes()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Sześcian " + i + " to:  " + i * i * i);
            }
        }
    }
}


