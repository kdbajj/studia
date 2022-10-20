using System;
using System.Threading;

namespace Z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintSquares);
            Thread thread2 = new Thread(PrintQubes);

            thread.Start();
            thread.Join();

            thread2.Start();
            thread2.Join();

            PrintHelloMyFriend();

            Console.ReadKey();
        }

        static void PrintSquares()
        {
            Console.WriteLine("tutaj są kwadraty");

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Kwadrat " + i + " to:  " + i * i);
            }

        }

        static void PrintHelloMyFriend()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine(i + ". Hello my friend!");
            while
            (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static void PrintQubes()
        {
            Console.WriteLine("tutaj są szcześciany");

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Sześcian " + i + " to:  " + i * i * i);
            }
        }
    }
}