// [assembly:CLSCompliant(true)]
// public class GFG{
//     public static void Main(string[] args){
//         Console.WriteLine("Geekss....");
//     }
// }


// CLSCompliantAttribute applied to entire assembly
[assembly:CLSCompliant(false)]
public class GFG {
    public uint z;
}

class ObsoleteAttributes{
    [Obsolete("method1 is obsolete", true)]
    public static void method1(){
        Console.WriteLine("this is Method1");
    }

    public static void method2(){
        Console.WriteLine("this is Method2");
    }
}

class FlagAttributes{
    enum Colours {
        Red,
        Black,
        Grey
    }
    [Flags] enum ColoursFlags {Red,
        Blue,
        Yello
    }

    public static void Main(){
        Console.WriteLine((Colours.Red | Colours.Grey));
        Console.WriteLine((ColoursFlags.Red | ColoursFlags.Blue).ToString());

        // ObsoleteAttributes.method1();
        ObsoleteAttributes.method2();
    }
}