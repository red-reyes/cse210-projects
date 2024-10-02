using System;

class Program
{
    static void Main(string[] args)
    {
        //make fractions using different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(4, 13);
        Fraction fraction4 = new Fraction(2, 7);

        //display fractional and decimal values
        Console.WriteLine("Fraction 1");
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine("Fraction 2");
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine("Fraction 3");
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine("Fraction 4");
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        //test getters and setters
        fraction1.SetTop(6);
        fraction1.SetBottom(17);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
    }
}