public class Base{ }
public class Derived : Base { }
class Program{
    public static void Main()
    {
        Base b = new Base();
        Console.WriteLine(b is Base);
        Console.WriteLine(b is Derived);

        Derived d = new Derived();
        Console.WriteLine(d is Base);
        Console.WriteLine(d is Derived);

        string str1 = "Hello";
        object obj1 = str1;
        string? str2 = obj1 as string;

        if (str2 != null)
            Console.WriteLine("Converted");
        else
            Console.WriteLine("Not Converted");
    }
}