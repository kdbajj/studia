using System;
using System.Threading;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintSquares);
            thread.Start();
            thread.Join();

            PrintQubes();
            PrintHelloMyFriend();

            Console.ReadKey();
        }

        static void PrintSquares()
        {

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
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Sześcian " + i + " to:  " + i * i * i);
            }
        }
    }
}