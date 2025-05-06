// -------------- Named parameters -------------- //

class MethodParameters(){
    public static void AddStrNamedParams(string s1, string s2, string s3){
        string result = s1 + s2 + s3;
        Console.WriteLine("Final string: " + result);
    }

    static void CompareRefValue(ref string val){
        if(val == "GFG")
            Console.WriteLine("Value is same => " + val);
        
        val = "CodeChef";
    }

    public static void AddNumOutParam(out int num){
        num = 40;
        num += 12;
    }

    // public static void DetailDefaultParams(string name, int age, string college = "")

    public static int MulVal(params int[] num){
        int res = 1;
        foreach (int j in num){
            res *= j;
        }
        Console.WriteLine(res);
        return res;
    }


    static public void Main(){
        AddStrNamedParams(s1: "Geeks", s3: "Geeks", s2: "for");

        string val = "GFG";
        CompareRefValue(ref val);
        Console.WriteLine(val);

        int num;
        AddNumOutParam(out num);
        Console.WriteLine($"Modified value for num is {num}");

        int nums = MulVal(20,34,12,25);
        Console.WriteLine($"value is {nums}");
    }    
}


