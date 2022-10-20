using System;
using System.Threading;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(PrintSquares);
            thread.Start();

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
    }
}