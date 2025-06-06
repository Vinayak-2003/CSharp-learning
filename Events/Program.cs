public delegate string MyDel(string str);

class EventProgram
{
    public event MyDel MyEvent;

    public EventProgram()
    {
        this.MyEvent += new MyDel(this.WelcomeUser);
    }

    public string WelcomeUser(string username)
    {
        return "Welcome " + username;
    }

    // public static void Main(string[] args)
    // {
    //     EventProgram obj1 = new EventProgram();
    //     string result = obj1.MyEvent("Vinayak");
    //     Console.WriteLine(result);
    // }
}