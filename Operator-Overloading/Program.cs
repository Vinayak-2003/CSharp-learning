using System.Security.Cryptography;

class UnaryOperaorOverloading{
    public int num1, num2;
    public UnaryOperaorOverloading(int n1, int n2){
        num1 = n1;
        num2 = n2;
    }

    public static UnaryOperaorOverloading operator -(UnaryOperaorOverloading c1){
        c1.num1 = -c1.num1;
        c1.num2 = -c1.num2;
        return c1;
    }

    public void Print(){
        Console.WriteLine($"""
        Num1 = {num1},
        Num2 = {num2}
        """);
    }

    public int Sum(){
        return num1 + num2;
    }
}

class Program{
    public static void Main()
    {
        UnaryOperaorOverloading cal = new UnaryOperaorOverloading(-15, 30);
        cal = -cal;
        cal.Print();
        int ans = cal.Sum();
        Console.WriteLine(ans);

        BinaryOperatorOverloading num1 = new BinaryOperatorOverloading(200);
        BinaryOperatorOverloading num2 = new BinaryOperatorOverloading(30);
        BinaryOperatorOverloading num3 = new BinaryOperatorOverloading();

        num3 = num1 + num2;
        num1.Display();
        num2.Display();
        num3.Display();

        var a = new Fraction(4, 16);
        // var b = new Fraction(2, 4);
        Console.WriteLine(-a);
        // Console.WriteLine(a + b);
        // Console.WriteLine(a - b);
        // Console.WriteLine(a * b);
        // Console.WriteLine(a / b);
    }
}