using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);
        Fraction fraction5 = new Fraction(6, 7);

        string fraction1String = fraction1.GetFractionString();
        double fraction1Value = fraction1.GetDecimalValue();

        string fraction2String = fraction2.GetFractionString();
        double fraction2Value = fraction2.GetDecimalValue();


        string fraction3String = fraction3.GetFractionString();
        double fraction3Value = fraction3.GetDecimalValue();

        string fraction4String = fraction4.GetFractionString();
        double fraction4Value = fraction4.GetDecimalValue();

        string fraction5String = fraction5.GetFractionString();
        double fraction5Value = fraction5.GetDecimalValue();

        Console.WriteLine(fraction1String);
        Console.WriteLine(fraction1Value);

        Console.WriteLine(fraction2String);
        Console.WriteLine(fraction2Value);

        Console.WriteLine(fraction3String);
        Console.WriteLine(fraction3Value);

        Console.WriteLine(fraction4String);
        Console.WriteLine(fraction4Value);

        Console.WriteLine(fraction5String);
        Console.WriteLine(fraction5Value);
    }
}