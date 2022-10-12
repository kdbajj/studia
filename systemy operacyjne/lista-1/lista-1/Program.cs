﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


/*Zadanie 1
 * W funkcji main należy wywołać funkcję print squares, wypisuje kwadraty kolejnych liczb naturalnych od 1 do 100.
 * Poniżej tej funkcji należy wypisać 100 razy "Hello my friend". Program ma zakończyć się po naciśnięciu esc.
 * 
Zadanie 2
dorzucamy nowy wątek w wątku głównym (wywołana w main ale nowy wątek)

Zadanie 3
*/


namespace lista_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread thr = new Thread(new ThreadStart(PrintSquares));
            thr.Start();
            thr.Join();

            PrintQubes();

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


