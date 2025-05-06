class Vehicle{                              // Base class
    public string Brand = "Ford";
    public int noOfWheels = 4;
    public void blowHorn(){
        Console.WriteLine("blowwwinggg.....");
    }
}

class Car : Vehicle{                        // Derived class
    public string modelName = "Mustang";
}

class Program{
    static void Main(string[] args){
        Car newCar = new Car();
        newCar.blowHorn();

        Console.WriteLine(newCar.Brand + " " + newCar.modelName + " have " + newCar.noOfWheels + " wheels.");
    }
}