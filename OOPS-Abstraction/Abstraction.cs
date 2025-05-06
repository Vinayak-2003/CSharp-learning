abstract class Animal{
    public abstract void animalSound();
    public void sleep(){
        Console.WriteLine("Zzzzzzz....");
    }
}

// to access abstract class it must be inherited into another class 
class Dog : Animal{
    public override void animalSound(){
        Console.WriteLine("The dog barks...");
    }
}

class Program{
    static void Main(string[] args){
        Dog animal1 = new Dog();
        animal1.animalSound();
        animal1.sleep();
    }
}