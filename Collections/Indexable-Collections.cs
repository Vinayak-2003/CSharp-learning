public partial class Collections{
    public static void IteratableCollections(){
        // string list
        List<string> Fruits = ["apple", "mango", "banana", "lichi"];
        foreach (var fruit in Fruits){
            Console.Write(fruit + " ");
        }

        Fruits.Remove("mango");
        Console.WriteLine();

        for (var i=0;i<Fruits.Count;i++){
            Console.Write(Fruits[i] + " ");
        }

        Fruits.Add("papaya");
        Console.WriteLine();

        foreach (var fruit in Fruits){
            Console.Write(fruit + " ");
        }
        Console.WriteLine();


        // int list
        List<int> numbers = [0,1,2,3,4,5,6,7,8,9];

        for (var i=numbers.Count-1;i>=0;i--){
            if (numbers[i]%2 == 1){
                numbers.RemoveAt(i);
            }
        }

        numbers.ForEach(
            num => Console.Write(num + " "));
        Console.WriteLine();


        // list using a class
        var Galaxies = new List<Galaxy>{
            new() { Name="Tadpole", MegaLightYears=400},
            new() {Name="Pinwheel", MegaLightYears=25},
            new() {Name="Milky Way", MegaLightYears=0},
            new() {Name="Andromeda", MegaLightYears=3},
        };

        foreach (Galaxy galaxy in Galaxies){
            Console.WriteLine(galaxy.Name + "  " + galaxy.MegaLightYears);
        }
    }
}

public class Galaxy{
    public string? Name { get; set; }
    public int? MegaLightYears {get; set; }
}