
using System;
using System.Diagnostics.Contracts;
using System.Security;
class Enums {
    public enum Month{
        Jan, Feb, Apr=4, May, Mar
    }
}

// ------------------------------ conditional enums ------------------------------ // 
class Perimeter{
    public enum Shapes{
        Circle,
        Square
    }

    public void GetPerimeter(int val, Shapes shape){
        if (shape == Shapes.Circle){
            Console.WriteLine("Circumference of circle is {0}", 2*Math.PI*val);
        }
        else{
            Console.WriteLine("Perimter of Square is {0}", 4*val);
        }
    }
}

// ------------------------------ changing data type ------------------------------ //
enum Button : byte{
    OFF,
    ON
}

// ------------------------------ Enum type as bit flags ------------------------------ //
[Flags]
public enum Days{
    None = 0,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 4,
    Thursday = 8,
    Friday = 16,
    Saturday = 32,
    Sunday = 64,
    Weekend = Saturday | Sunday
}

class Program{
    public static void Main(string[] args){
        Console.WriteLine("The value of jan in month enum is " + (int)Enums.Month.Jan);   // 0
        Console.WriteLine("The value of feb in month enum is " + (int)Enums.Month.Feb);   // 1
        Console.WriteLine("The value of mar in month enum is " + (int)Enums.Month.Mar);   // 4
        Console.WriteLine("The value of apr in month enum is " + (int)Enums.Month.Apr);   // 2
        Console.WriteLine("The value of may in month enum is " + (int)Enums.Month.May);   // 3


        Perimeter perimeter1 = new Perimeter();
        perimeter1.GetPerimeter(5, Perimeter.Shapes.Circle);
        perimeter1.GetPerimeter(6, Perimeter.Shapes.Square);


        byte b = 0;
        if (b == (byte)Button.OFF){
            Console.WriteLine("Electricity is switch off");
            Console.WriteLine((byte)Button.OFF);
        }
        else if (b == (byte)Button.ON){
            Console.WriteLine("Electricity is switch on");
            Console.WriteLine((byte)Button.ON);
        }
        else
            Console.WriteLine("byte cannot hold another value");


        Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
        Console.WriteLine("Meeting days are {0}", meetingDays);

        bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
        Console.WriteLine($"Meeting on tuesday {isMeetingOnTuesday}");

        var a = (Days)37;
        Console.WriteLine(a);
    }
}