interface IShape{
    double Area(int l, int b);
    double Perimeter(int l, int b);
    void Display();
}

class Rectangle : IShape{
    public double Area(int l, int b){
        return l*b;
    }
    public double Perimeter(int l, int b){
        return 2*(l+b);
    }
    public void Display(){
        Console.WriteLine("Rectangle class");
    }
}

class Circle : IShape{
    public double Area(int r, int b=0){
        return Math.PI*r*r;
    }
    public double Perimeter(int r, int b=0){
        return 2*Math.PI*r;
    }
    public void Display(){
        Console.WriteLine("Circle class");
    }
}

class Program{
    public static void Main(string[] args){
        Rectangle shape1 = new Rectangle();
        double rectangleArea = shape1.Area(4,2);
        Console.WriteLine(rectangleArea);

        Circle shape2 = new Circle();
        double circlePerimeter = shape2.Perimeter(4,2);
        Console.WriteLine(circlePerimeter);

        IShape interfaceObj = new Circle();
        interfaceObj.Display();
    }
}