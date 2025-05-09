static class Tutorial{
    static Tutorial(){
        Console.WriteLine("Static constructor");
    }
    // only static members can reside inside the static class
    public static string Topic = "C#";
    public static void GetMeTopics(){
        Console.WriteLine("Architecture of C#");
    }
}

class Tutorial2{
    static Tutorial2(){
        Console.WriteLine("Static constructor2");
    }
    public Tutorial2(int num){
        Console.WriteLine("Instance constructor {0}", num);
    }
}

// ----------------------- shared functionality ----------------------- //
class Users{
    public static int userCount = 0;
    public string name;
    public Users(string name){
        this.name = name;
        userCount++;
    }
}


class Program{
    public static void Main(){
        Console.WriteLine("Topic name is {0}", Tutorial.Topic);
        Tutorial.GetMeTopics();

        Tutorial2 tutorialObj = new Tutorial2(1);

        Users user1 = new Users("Vinayak");
        Users user2 = new Users("Somil");

        Console.WriteLine("user count is {0}", Users.userCount);
    }
}