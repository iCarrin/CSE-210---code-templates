using System;
using System.Data;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       
        Fraction one = new Fraction();
        Fraction twoOne = new Fraction(2);
        Fraction half = new Fraction(1, 2);
        Fraction fourteenGauge = new Fraction(5, 64);

        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(one.GetFractionString());

        Console.WriteLine(twoOne.GetDecimalValue());
        Console.WriteLine(twoOne.GetFractionString()); 

        Console.WriteLine(half.GetDecimalValue());
        Console.WriteLine(half.GetFractionString());

        Console.WriteLine(fourteenGauge.GetDecimalValue());
        Console.WriteLine(fourteenGauge.GetFractionString());
    }
}