using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Z1
{
     class Program
    { 
        static int[] array = new int[100];

    static void IncreaseValues()
    {
        Random random = new Random();
        for (int i = 0; i < 10000; i++)
        {
            int index = random.Next(100);
            array[index]++;
        }
    }

    static void DecreaseValues()
    {
        Random random = new Random();
        for (int i = 0; i < 10000; i++)
        {
            int index = random.Next(100);
            array[index]--;
        }
    }
    
    
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(IncreaseValues);
            Thread thread2 = new Thread(DecreaseValues);

            for (int i = 0; i < 100; i++)
            {
                array[i] = 0;
            }

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
     }
}

//Po wykonaniu testu otrzymujemy zbiór danych o rozkładzie zbliżonym do rozkładu normalnego.
//Wniosek z tego wynika, że procesor przydziela równe ilości czasu obu wątkom, co pozwala im równomiernie zmieniać wartości w tablicy.