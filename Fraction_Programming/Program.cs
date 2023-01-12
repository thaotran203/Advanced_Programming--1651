using System;

namespace Fraction_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fraction_Programming.Fraction fraction1 = new Fraction_Programming.Fraction();
            Fraction_Programming.Fraction fraction2 = new Fraction_Programming.Fraction();

            Console.WriteLine("Enter fraction 1:");
            fraction1.inputFraction();
            Console.WriteLine("Display fraction 1:");
            fraction1.displayFraction();

            Console.WriteLine("Display fraction 1 in a decimal number: ");
            fraction1.displayDecimal();
            Console.WriteLine();

            Console.WriteLine("Enter fraction 2:");
            fraction2.inputFraction();
            Console.WriteLine("Display fraction 2:");
            fraction2.displayFraction();

            Console.WriteLine("Display fraction 2 in a decimal number: ");
            fraction2.displayDecimal();
            Console.WriteLine();

            Fraction_Programming.Fraction f = fraction1.add(fraction2);
            Console.WriteLine("Add two fraction: ");
            f.displayFraction();

            Fraction_Programming.Fraction f2 = fraction1.subtract(fraction2);
            Console.WriteLine("Subtract two fraction: ");
            f2.displayFraction();

            Fraction_Programming.Fraction f3 = fraction1.multiply(fraction2);
            Console.WriteLine("Multiply two fraction: ");
            f3.displayFraction();

            Fraction_Programming.Fraction f4 = fraction1.divide(fraction2);
            Console.WriteLine("Divide two fraction: ");
            f4.displayFraction();
        }
    }
}
