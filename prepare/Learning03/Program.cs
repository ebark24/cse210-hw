using System;

class Program
{
    static void Main(string[] args)
    {
        fraction fraction1 = new fraction();
        string frac1 = fraction1.GetFraction();
        double deci1 = fraction1.GetDecimalValue();
        Console.WriteLine(frac1);
        Console.WriteLine(deci1);

        fraction fraction2 = new fraction(5);
        string frac2 = fraction2.GetFraction();
        double deci2 = fraction2.GetDecimalValue();
        Console.WriteLine(frac2);
        Console.WriteLine(deci2);

        fraction fraction3 = new fraction(3,4);
        string frac3 = fraction3.GetFraction();
        double deci3 = fraction3.GetDecimalValue();
        Console.WriteLine(frac3);
        Console.WriteLine(deci3);

        fraction fraction4 = new fraction(1,3);
        string frac4 = fraction4.GetFraction();
        double deci4 = fraction4.GetDecimalValue();
        Console.WriteLine(frac4);
        Console.WriteLine(deci4);
    }


}