using System.Security.Cryptography.X509Certificates;

class Example
{
    public string name { get; set; }
    public Example()
    {
        Console.WriteLine("Constructor is called !!");
        name = "Vinayak";
        Console.WriteLine(name);
    }

    public void callMyName()
    {
        Console.WriteLine(name);
    }
    
    ~Example(){
        Console.WriteLine("Destructor is called");
        Console.WriteLine(name);
    }
}

class Program{
    static void Main(){
        Example ex = new Example();
        ex.callMyName();
        ex = null;
        GC.Collect();
    }
}