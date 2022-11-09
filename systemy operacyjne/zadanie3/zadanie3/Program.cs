using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        static readonly List<int> List = Enumerable.Repeat(0, 100).ToList();
        static void Main(string[] args)

        {
            var th = new Thread(AddElements);
            var th2 = new Thread(SubstractElements);


            th.Start();
            th2.Start();

            th.Join();
            th2.Join();
            


        }
        private static void AddElements()
        {
            int loop = 10000;

            Random random = new Random();

            for (int i = 0; i < loop; i++)
            {
                int randomNumber = random.Next(0, 100);
                List[randomNumber] += 1;
            }
        }
        private static void SubstractElements()
        {
            int loop = 10000;

            Random random = new Random();

            for (int i = 0; i < loop; i++)
            {
                int randomNumber = random.Next(0, 100);
                List[randomNumber] -= 1;
            }
        }
    }
}
