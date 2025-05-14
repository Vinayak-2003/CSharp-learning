using System.Reflection.Metadata.Ecma335;

public struct Address{
    public string city;
    public string state;
}

public struct Person{
    public string Name;
    public int Height;
    public int Weight;

    // nesting of structure
    public Address A1;
}

// ----------------------------- readonly struct ----------------------------- // 
public readonly struct Coords{
    // public readonly double X;
    // public readonly double Y;
    public Coords(double x, double y){
        X = x;
        Y = y;
    }
    public double X { get; init; }
    public double Y { get; init; }

    public override string ToString() => $"({X} {Y})";
}

class Program{
    public static void Main(string[] args){
        Person P1;
        P1.Name = "Vinayak";
        P1.Height = 6;
        P1.Weight = 67;
        P1.A1.city = "Jaipur";
        P1.A1.state = "Rajasthan";

        // copy one structure object to other object using "="
        Person P2;
        P2 = P1;

        Console.WriteLine($"""
        Name of the person is {P1.Name}, height is {P1.Height} and weight is {P1.Weight}
        City is {P1.A1.city} in state {P1.A1.state}
        -------------------
        Name of the person is {P2.Name}, height is {P2.Height} and weight is {P2.Weight}
        City is {P2.A1.city} in state {P2.A1.state}
        """);

        var coords1 = new Coords(0, 0);
        Console.WriteLine(coords1);

        // nondestructive mutation
        var coords2 = coords1 with {X=3};
        Console.WriteLine(coords2);

        var coords3 = coords1 with {X=1, Y=5};
        Console.WriteLine(coords3);
    }
}