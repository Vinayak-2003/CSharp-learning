static class BoxingUnboxing{
    public static void BoxingImplement(){
        int num = 123;
        object obj = num;                                   // implicit conversion

        Console.WriteLine($"Value of num is {num}");
        Console.WriteLine($"Value of boxed object Obj is {obj}");
        Console.WriteLine();

        num = 456;
        Console.WriteLine("After changing num 123 to 456");
        Console.WriteLine($"Updated Value of num is {num}");
        Console.WriteLine($"Updated Value of boxed object Obj is {obj}");
        Console.WriteLine();

        obj = 789;
        Console.WriteLine("After changing obj 123 to 789");
        Console.WriteLine($"Updated Value of num is {num}");
        Console.WriteLine($"Updated Value of boxed object Obj is {obj}");
    }

    public static void UnboxingImplement(){
        int num = 123;
        object obj2 = num;                          // expilict conversion
        object obj3 = 3;

        try{
            int num2 = (int)obj2;                         // unboxing
            Console.WriteLine($"Unboxing {num2}");
        }
        catch (InvalidCastException e){
            Console.WriteLine($"Incorrect Unboxing: {e}");
        }
    }
}

class Program{
    public static void Main(){
        BoxingUnboxing.BoxingImplement();
        BoxingUnboxing.UnboxingImplement();
    }
}