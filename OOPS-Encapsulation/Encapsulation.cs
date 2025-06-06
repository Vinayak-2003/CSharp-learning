// -------------------- Encapsulation (Access modification) -------------------- //

class Car{
    private string model = "Audi";      //field
    public string Model{                // property
        get { return model; }           // returns the value of variable model
        set { model = value; }          // assigns value to the model variable
    }

    public int year = 2024;
    protected int gears = 5;
    internal string fuelType = "Diesel";

    public Car(){
        Console.WriteLine("Model---" + model);
    }

    // static void Main(string[] args){
    //     Car myObj = new Car();
    //     Console.WriteLine(myObj.model);             // accessible
    //     Console.WriteLine(myObj.year);              // accessible
    //     Console.WriteLine(myObj.gears);             // accessible
    // }
}


// -------------------- Properties -------------------- //

class CarProperties{
    private string model = "Audi";      //field
    public string Model{                // property
        get { return model; }           // returns the value of variable model
        set { model = value; }          // assigns value to the model variable
    }

    public CarProperties(){
        Console.WriteLine(model);
    }
}


// -------------------- short-hand / automatic property -------------------- //

class ShortCar{
        public string? Model
        { get; set; }
}


// -------------------- Implementing Data Encapsulation -------------------- //
public class Bank
{
    private double _Amount;
    public double Amount
    {
        get
        {
            return _Amount;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Pass a positive value");
            }
            else
            {
                _Amount = value;
            }
        }
    }
}


class Program{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        // Console.WriteLine(myObj.model);            // not accessible as it is only accessible in its own class
        Console.WriteLine(myObj.year);
        // Console.WriteLine(myObj.gears);            // not accessible because it needs to be inheried

        Console.WriteLine(myObj.Model);
        myObj.Model = "Mercedes Benz";
        Console.WriteLine(myObj.Model);

        ShortCar myShortCarObj = new ShortCar();

        Console.WriteLine(myShortCarObj.Model);
        myShortCarObj.Model = "Mercedes Benz";
        Console.WriteLine(myShortCarObj.Model);

        try
        {
            Bank bank = new Bank();
            bank.Amount = 100;
            Console.WriteLine("Amount in the bank is {0}", bank.Amount);

            bank.Amount = -150;
            Console.WriteLine("Amount in the bank is {0}", bank.Amount);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: {0}", e);
        }
    }
}