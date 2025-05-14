interface IShape1{
    double getArea();
}

interface IColor{
    string GetColor();
}

class Rectangle2 : IShape1, IColor{
    double length;
    double breadth;
    string color;
    public Rectangle2(double length, double breadth, string color){
        this.length = length;
        this.breadth = breadth;
        this.color = color;
    }
    public double getArea(){
        return length*breadth;
    }
    public string GetColor(){
        return color;
    }
}