using System.Data;
using System.Reflection.Metadata.Ecma335;

public readonly struct Fraction
{
    private readonly int num;
    private readonly int den;
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException($"Denominator cannot be zero {nameof(denominator)}");
        }

        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        num = numerator / gcd;
        den = denominator / gcd;
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
            Console.WriteLine($"a {a} b {b}");
        }
        return a;
    }

    // Unary operator overloading
    public static Fraction operator +(Fraction a) => a;
    public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

    // Binary operator overloading
    public static Fraction operator +(Fraction a, Fraction b)
        => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

    public static Fraction operator -(Fraction a, Fraction b)
        => a + (-b);

    public static Fraction operator *(Fraction a, Fraction b)
        => new Fraction(a.num * b.num, a.den * b.den);

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.num == 0)
            throw new DivideByZeroException();
        return new Fraction(a.num * b.den, a.den * b.num);
    }

    public override string ToString() => $"{num} / {den}";
}