using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*Zadanie 1
 * W funkcji main należy wywołać funkcję print squares, wypisuje kwadraty kolejnych liczb naturalnych od 1 do 100.
 * Poniżej tej funkcji należy wypisać 100 razy "Hello my friend". Program ma zakończyć się po naciśnięciu esc.
 * 
 Zadanie 2
dorzucamy nowy wątek w wątku głównym (wywołana w main ale nowy wątek)*/

namespace lista_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printSquares();
           

        }
        public static void printSquares()
        {
            int k = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Kwadrat " + i + " to:  " + i*i);
                
                k++;
                Console.WriteLine( k+ ". Hello my friend!");
            }
        }
    }
}


