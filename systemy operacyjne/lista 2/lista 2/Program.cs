
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static lista_2.ImportanThingsCalculator;

namespace lista_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Zadanie 1
                W funkcji main wywołaj 2 wątki, wywołującą metodę printCalculation, której definicja znajduje się w klasie importanThingsCalculator.
                W przytoczonej klasie zdefiniuj pole typu boolowskiego isDone. Metoda printCalculation powinna zawierać fragment, który będzie realizował
                wypisywanie tekstu alreadyDone, gdy wartość zmiennej isDone będzie ustawiona na true. Poza tą funkcjonalnośćią funkcja ma usypiać wątek
                20 razy na 100 milisekund, oraz realizować dodawanie dwóch predefiniowanych zmiennych, którego wartość jednej z nich będzie inkrementowana
                co pętlę. Po wykonaniu dodawania należy ustawić wartość isDone na true. Wątek główny w programie niech także uruchamia metodę printCalculation.
            
            Zadanie 2
            Napisz program obrazujący mechanizm czekania wątku na realizację zadania przekazanego innemu wątkowi. W tym celu powołaj do
            życia klasę CreateWithState. Niech ta klasa zawiera 2 pola, pierwsze z nich string - boilerPlate, oraz int value, oraz delegata
            callBack do funkcji exampleCallBack, konstruktor klasy oraz metodę Treathproc, której zadaniem będzie realizacja zadania wyczekiwania
            na drugi wątek.*/



            ImportanThingsCalculator important = new ImportanThingsCalculator();
            ImportanThingsCalculator important2 = new ImportanThingsCalculator();

            Thread thread1 = new Thread(important.printCalculation);
            Thread thread2 = new Thread(important2.printCalculation);


            thread1.Start();
            thread2.Start();

            important.printCalculation();
            important2.printCalculation();

        }


    }

}
    
