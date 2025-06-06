// -------------- Named parameters -------------- //

class MethodParameters(){
    // Named parameters
    public static void AddStrNamedParams(string s1, string s2, string s3){
        string result = s1 + s2 + s3;
        Console.WriteLine("Final string: " + result);
    }

    // ref parameter
    static void CompareRefValue(ref string val){
        if(val == "GFG")
            Console.WriteLine("Value is same => " + val);
        
        val = "CodeChef";
    }

    public static void RefMethod(ref int refArgument){
        refArgument += 45;
        Console.WriteLine("Reference argument " + refArgument);
    }

    // out parameter
    public static void AddNumOutParam(out int num){
        num = 40;
        num += 12;
    }

    public static void AddTwoOutParams(out int p, out int q)
    {
        p = 30;
        q = 40;
        p += q;
        q += p;
    }

    // optional or default parameters
    public static void DetailDefaultParams(string name,
                                            int age,
                                            string college = "MUJ",
                                            int year = 2025)
    {
        Console.WriteLine($"""
            Name = {name},
            Age = {age},
            University = {college},
            Passing-Year = {year}
        """);
    }

    // dynamic parameter
    public static void DynamicParameters(dynamic val){
        val *= val;
        Console.WriteLine(val);
    }

    // value parameters
    public static string AddString(string str1, string str2){
        return str1 + str2;
    }

    // params 
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

        int number = 23;
        RefMethod(ref number);

        int num = 6;
        AddNumOutParam(out num);
        Console.WriteLine($"Modified value for num is {num}");

        int i, j;
        AddTwoOutParams(out i, out j);
        Console.WriteLine($"Addition of two out params are: {i}");
        Console.WriteLine($"Addition of two out params are: {j}");

        DetailDefaultParams("Vinayak Kanchan", 22);

        DynamicParameters(12.22);

        string AddedString = AddString("Hello", "World!!");
        Console.WriteLine(AddedString);

        int nums = MulVal(20,34,12,25);
        Console.WriteLine($"value from params is {nums}");
    }    
}


