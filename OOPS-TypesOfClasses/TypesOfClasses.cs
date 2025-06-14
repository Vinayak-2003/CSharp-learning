﻿// --------------------- Abstract class --------------------- //
abstract class AbstractClass{
    public void AbstractDisplay(){
        Console.WriteLine("this is an abstract class");
    }
}

class DerivedAbstractClass : AbstractClass{
    public DerivedAbstractClass(){
        Console.WriteLine("this is a derived class for abstract class");
    }
}

// --------------------- partial class --------------------- //
public partial class PartialClassA{
    public void Display2(){
        Console.WriteLine("This is the implementation of partial class");
    }
}

// --------------------- sealed class --------------------- //
sealed class SealedClass{
    public void SealedDisplay(){
        Console.WriteLine("This is the implementation of sealed class");
    }
}

// --------------------- static class --------------------- //
static class StaticClass{
    public static string CollegeName = "Manipal University";
}

public class Program{
    static void Main(string[] args){
        DerivedAbstractClass abstractObj = new DerivedAbstractClass();
        abstractObj.AbstractDisplay();

        PartialClassA partialClassAObj = new PartialClassA("Vinayak", 3);
        partialClassAObj.Display();

        SealedClass sealedClassObj = new SealedClass();
        sealedClassObj.SealedDisplay();

        // StaticClass staticClassObj = new StaticClass();
        // error
        Console.WriteLine(StaticClass.CollegeName);
    }
}