using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions F1 = new Fractions();
        Fractions F2 = new Fractions(6);
        Fractions F3 = new Fractions(6, 7);


        Fractions t = new Fractions();
        t.SetTop(9);
        Console.WriteLine(t.GetTop());

        Fractions b = new Fractions();
        b.SetBottom(10);
        Console.WriteLine(b.GetBottom());

        Fractions f = new Fractions();

        string frac = f.GetFractionString(f.GetTop(), f.GetBottom());
        Console.WriteLine(frac);

        double dec = f.GetDecimalValue(f.GetTop(), f.GetBottom());
        Console.WriteLine($"{dec}");

    }
}