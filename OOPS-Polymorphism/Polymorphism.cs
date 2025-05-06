class Birds{
    public string name = "generic bird";
    public virtual void Habitat(){
        Console.WriteLine("Birds lives in");
    }
}

class Pigeon : Birds{
    public Pigeon(){
        name = "pigeon";
    }
    public override void Habitat(){
        Console.WriteLine("Pigeons live in cities and on buildings.");
    }
}

class Penguine : Birds{
    public Penguine(){
        name = "penguine";
    }
    public override void Habitat(){
        Console.WriteLine("Penguines lives in snowy places.");
    }
}

class Program{
    static void Main(string[] args){
        Penguine bird1 = new Penguine();
        Pigeon bird2 = new Pigeon();

        Console.WriteLine($"Name: {bird1.name}");
        bird1.Habitat();

        Console.WriteLine($"Name: {bird2.name}");
        bird1.Habitat();
    }
}