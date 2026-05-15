using System;

namespace Lab9_Inheritance
{
    public class Rational : Pair
    {
        public long Numerator { get; private set; }
        public long Denominator { get; private set; }

        public Rational(long numerator, long denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Знаменник не може бути 0");

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            long gcd = GCD(Math.Abs(numerator), denominator);
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;
        }

        private long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override Pair Add(Pair other)
        {
            Rational r = (Rational)other;
            return new Rational(
                Numerator * r.Denominator + r.Numerator * Denominator,
                Denominator * r.Denominator
            );
        }

        public override Pair Sub(Pair other)
        {
            Rational r = (Rational)other;
            return new Rational(
                Numerator * r.Denominator - r.Numerator * Denominator,
                Denominator * r.Denominator
            );
        }

        public override Pair Mul(Pair other)
        {
            Rational r = (Rational)other;
            return new Rational(
                Numerator * r.Numerator,
                Denominator * r.Denominator
            );
        }

        public override Pair Div(Pair other)
        {
            Rational r = (Rational)other;
            return new Rational(
                Numerator * r.Denominator,
                Denominator * r.Numerator
            );
        }

        public override void Print()
        {
            if (Denominator == 1)
                Console.WriteLine(Numerator);
            else
                Console.WriteLine($"{Numerator}/{Denominator}");
        }
    }
}