using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lista_2
{
    internal class ImportanThingsCalculator
    {
        bool isDone = true;

        public void printCalculation()
        {

            int zmienna1 = 1;
            int zmienna2 = 1;
            if (isDone)
            {
                Console.WriteLine("Already done");
            }

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(1000);
                zmienna1++;
                zmienna1 = zmienna1 + zmienna2;
            }

        }



    }
}

