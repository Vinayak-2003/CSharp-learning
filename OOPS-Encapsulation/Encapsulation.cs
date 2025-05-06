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

// class Program{
//     static void Main(string[] args){
//         Car myObj = new Car();
//         // Console.WriteLine(myObj.model);            // not accessible as it is only accessible in its own class
//         Console.WriteLine(myObj.year);
//         // Console.WriteLine(myObj.gears);            // not accessible because it needs to be inheried

//         Console.WriteLine(myObj.Model);
//         myObj.Model = "Mercedes Benz";
//         Console.WriteLine(myObj.Model);
//     }
// }


// -------------------- Properties -------------------- //

// class Car{
//     private string model = "Audi";      //field
//     public string Model{                // property
//         get { return model; }           // returns the value of variable model
//         set { model = value; }          // assigns value to the model variable
//     }

//     public Car(){
//         Console.WriteLine(model);
//     }
// }


// -------------------- short-hand / automatic property -------------------- //

// class Car{
//         public string Model
//         { get; set; }
// }

// class Program{
//     static void Main(string[] args){
//         Car myObj = new Car();

//         Console.WriteLine(myObj.Model);
//         myObj.Model = "Mercedes Benz";
//         Console.WriteLine(myObj.Model);
//     }
// }

