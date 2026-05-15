using System;
using Lab9_Inheritance;

namespace Lab9_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Комплексні числа та Раціональні дроби\n");

            Console.WriteLine("Комплексні числа");

            Complex a = new Complex(2, 3);
            Complex b = new Complex(1, 4);

            Console.Write("a = "); a.Print();
            Console.Write("b = "); b.Print();

            Pair sum = a.Add(b);
            Console.Write("a + b = "); sum.Print();

            Pair diff = a.Sub(b);
            Console.Write("a - b = "); diff.Print();

            Pair prod = a.Mul(b);
            Console.Write("a * b = "); prod.Print();

            Pair quot = a.Div(b);
            Console.Write("a / b = "); quot.Print();

            Console.WriteLine("\n");

            Console.WriteLine("Раціональні дроби");

            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(1, 3);

            Console.Write("r1 = "); r1.Print();
            Console.Write("r2 = "); r2.Print();

            Pair rsum = r1.Add(r2);
            Console.Write("r1 + r2 = "); rsum.Print();

            Pair rdiff = r1.Sub(r2);
            Console.Write("r1 - r2 = "); rdiff.Print();

            Pair rprod = r1.Mul(r2);
            Console.Write("r1 * r2 = "); rprod.Print();

            Pair rquot = r1.Div(r2);
            Console.Write("r1 / r2 = "); rquot.Print();

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу");
            Console.ReadKey();
        }
    }
}