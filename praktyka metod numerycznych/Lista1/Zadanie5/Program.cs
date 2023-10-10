﻿using System;

class Program
{
    static void Main()
    {
        double x = 5.0;  // Wartość dla której obliczamy e^x
        double epsilon = 0.0001;  // Tolerancja błędu

        if (x > 0)
        {
            Console.WriteLine("Błąd jest względny");
        }
        else if (x < 0)
        {
            Console.WriteLine("Błąd jest bezwzględny");
        }


        double result = CalculateExponentialWzglednego(x, epsilon);
        Console.WriteLine(result);
    }

    static double CalculateExponentialWzglednego(double x, double epsilon)
    {
        double sum = 1.0;
        double term = x;
        int n = 1;

        while (Math.Abs(term) >= epsilon)
        {
            sum += term;
            n++;
            term *= x / n;
        }

        return sum;
    }
}