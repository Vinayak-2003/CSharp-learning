abstract class Motorcycle{
    public void StartEngine(){              // anyone can call this
        Console.WriteLine("Engine started ......");
    }
    protected void Addgas(int gallons){     // only derived classes can call this
        Console.WriteLine($"Total gas is {gallons}");
    }
    public virtual int Drive(int distance, int speed){      //derived class can override the base class implementation
        return 1;
    }
    public abstract double GetTopSpeed();   // derived class must implement this
}

class TestMotorcycle : Motorcycle{
    public override double GetTopSpeed(){
        return 102.4;
    }

    static void Main(){
        TestMotorcycle moto = new TestMotorcycle();

        moto.StartEngine();
        moto.Addgas(15);
        moto.Drive(5, 20);
        double speed = moto.GetTopSpeed();
        Console.WriteLine($"My top speed is {speed}");
    }
}