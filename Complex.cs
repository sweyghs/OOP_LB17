using System;

namespace Lab9_Inheritance
{
    public class Complex : Pair
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public override Pair Add(Pair other)
        {
            Complex c = (Complex)other;
            return new Complex(Re + c.Re, Im + c.Im);
        }

        public override Pair Sub(Pair other)
        {
            Complex c = (Complex)other;
            return new Complex(Re - c.Re, Im - c.Im);
        }

        public override Pair Mul(Pair other)
        {
            Complex c = (Complex)other;
            return new Complex(
                Re * c.Re - Im * c.Im,
                Re * c.Im + Im * c.Re
            );
        }

        public override Pair Div(Pair other)
        {
            Complex c = (Complex)other;
            double denom = c.Re * c.Re + c.Im * c.Im;
            return new Complex(
                (Re * c.Re + Im * c.Im) / denom,
                (Im * c.Re - Re * c.Im) / denom
            );
        }

        public override void Print()
        {
            if (Im >= 0)
                Console.WriteLine($"{Re} + {Im}i");
            else
                Console.WriteLine($"{Re} - {Math.Abs(Im)}i");
        }
    }
}