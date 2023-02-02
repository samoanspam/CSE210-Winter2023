using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        System.Console.WriteLine(frac1.GetFractionString());
        System.Console.WriteLine(frac1.GetDecimalValue());


        Fraction frac2 = new Fraction(6);
        System.Console.WriteLine(frac2.GetFractionString());
        System.Console.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(6,7);
        System.Console.WriteLine(frac3.GetFractionString());
        System.Console.WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new Fraction(1, 3);
        System.Console.WriteLine(frac4.GetFractionString());
        System.Console.WriteLine(frac4.GetDecimalValue());

    }
}