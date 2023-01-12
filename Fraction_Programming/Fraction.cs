using System;

namespace Fraction_Programming
{
    internal class Fraction
    {
        public int numerator { get; set; }
        public int denominator { get; set; }
        public Fraction()
        {

        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public void inputFraction()
        {

            Console.WriteLine("Enter the numerator: ");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator: ");
            int mau = int.Parse(Console.ReadLine());

            if (mau == 0)
            {
                Console.WriteLine("Please enter the fraction again!");
            }
            else
            {
                numerator = tu;
                denominator = mau;
            }
        }

        public static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void simplify(Fraction fraction)
        {
            int x = gcd(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= x;
            denominator /= x;

            //put minus before numerator
            if (denominator < 0)
            {
                denominator = -denominator;
                numerator = -numerator;
            }
        }

        public void displayFraction()
        {
            if (numerator * denominator > 0)
            {
                Console.WriteLine(Math.Abs(numerator) + "/" + Math.Abs(denominator));
            }
            else
            {
                Console.WriteLine(numerator + "/" + denominator);
            }
        }

        public Fraction add(Fraction fraction)
        {

            Fraction f = new Fraction();
            f.numerator = this.numerator * fraction.denominator + fraction.numerator * this.denominator;
            f.denominator = this.denominator * fraction.denominator;

            f.simplify(f);
            return f;
        }

        public Fraction subtract(Fraction fraction)
        {

            Fraction f = new Fraction();
            f.numerator = this.numerator * fraction.denominator - fraction.numerator * this.denominator;
            f.denominator = this.denominator * fraction.denominator;

            f.simplify(f);
            return f;
        }

        public Fraction multiply(Fraction fraction)
        {
            Fraction f = new Fraction();
            f.numerator = this.numerator * fraction.numerator;
            f.denominator = this.denominator * fraction.denominator;
            f.simplify(f);
            return f;
        }

        public Fraction divide(Fraction fraction)
        {

            Fraction f = new Fraction();
            f.numerator = this.numerator * fraction.denominator;
            f.denominator = this.denominator * fraction.numerator;
            f.simplify(f);
            return f;
        }

        public void displayDecimal()
        {
            if (numerator * denominator > 0)
            {
                double num = (double)Math.Abs(numerator) / Math.Abs(denominator);
                Console.WriteLine(num);
            }
            else
            {
                double num = (double)numerator / denominator;
                Console.WriteLine(num);
            }
        }
    }
}
