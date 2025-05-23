delegate void CustomeCallback(string s);
public delegate void AddNum(int a, int b);
public delegate void SubNum(int a, int b);

class DelegateImplement{
    public void Sum(int a, int b){
        Console.WriteLine($"{a} + {b} is {a+b}");
    }
    public void Sub(int a, int b){
        Console.WriteLine($"{a} - {b} is {a-b}");
    }

    // ------------------ built-in delegates ------------------ //
    public static void MultiplyActionDelegate(int num1, int num2){
        Console.WriteLine(num1 * num2);
    }

    public static int AddDoubleValueFuncDelegate(int num){
        return num+num;
    }

    public static bool PrediacteStringDelegate(string str){
        if (str.Length < 7)
            return true;
        else
            return false;
    }

    // ------------------ multicast delegate ------------------ //
    public static void Hello(string s){
        Console.WriteLine($"    Hello, {s}");
    }
    public static void GoodBye(string s){
        Console.WriteLine($"   GoodBye !! {s}");
    }
}

class Program{
    public static void Main(){
        DelegateImplement calDelegateObj = new DelegateImplement();

        AddNum add_obj1 = new AddNum(calDelegateObj.Sum);
        SubNum sub_obj1 = new SubNum(calDelegateObj.Sub);

        add_obj1(2,3);
        sub_obj1(5,2);

        // Action<in T ...>
        Action<int, int> multiplyDel = DelegateImplement.MultiplyActionDelegate;
        multiplyDel(12,6);

        // Func<in T ....., out T>
        Func<int, int> FuncDelegate = DelegateImplement.AddDoubleValueFuncDelegate;
        Console.WriteLine($"Func Delegate value is {FuncDelegate(6)}");

        // Predicate<>
        Predicate<string> checkString = DelegateImplement.PrediacteStringDelegate;
        Console.WriteLine(checkString("Hello"));

        // multicast
        CustomeCallback hiDel, byeDel, multiDel, multiMinusDel;
        hiDel = DelegateImplement.Hello;
        byeDel = DelegateImplement.GoodBye;
        multiDel = hiDel + byeDel;
        multiMinusDel = (multiDel - hiDel)!;

        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");
        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("B");
        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");
        Console.WriteLine("Invoking delegate multiMinusHiDel:");
        multiMinusDel("D");
    }
}