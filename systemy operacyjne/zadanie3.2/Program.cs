﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zadanie3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var th = new Thread(ExecuteInForeground);
        }
    }
}
