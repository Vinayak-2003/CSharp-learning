abstract class Shape{
    public abstract int GetArea();              // abstract method
    protected int n;
    public abstract int n1{ get; set; }         // abstract property
}

class Square : Shape{
    private int side;
    public override int n1{                     // body for abstract property
        get{
            return n;
        }
        set{
            n = value*2;
        }
    }
    public Square(int n) => side = n;
    public override int GetArea() => side * side;       // body for abstract method

    static void Main(string[] args){
        var sq = new Square(12);
        Console.WriteLine($"Area of square is = {sq.GetArea()}");
        sq.n1 = 5;
        Console.WriteLine(sq.n1);
    }
}