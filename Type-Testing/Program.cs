public class Base{ }
public class Derived : Base { }
class Program{
    public static void Main(){
        Base b = new Base();
        Console.WriteLine(b is Base);
        Console.WriteLine(b is Derived);

        Derived d = new Derived();
        Console.WriteLine(d is Base);
        Console.WriteLine(d is Derived);
    }
}