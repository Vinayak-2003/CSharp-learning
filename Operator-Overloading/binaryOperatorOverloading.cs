class BinaryOperatorOverloading{
    public int number = 0;

    public BinaryOperatorOverloading() {}       // no-argument constructor

    public BinaryOperatorOverloading(int n){    // parameterized constructor
        number = n;
    }

    public static BinaryOperatorOverloading operator + (BinaryOperatorOverloading b1,
                                                        BinaryOperatorOverloading b2)
    {
        BinaryOperatorOverloading b3 = new BinaryOperatorOverloading(12);
        b3.number = b2.number + b1.number;
        return b3;
    }

    public void Display(){
        Console.WriteLine("{0}", number);
    }
}