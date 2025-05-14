using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public partial class Collections{
    private static Dictionary<string, Element> BuildDictionary() =>
    new(){
        {"K", new() {Symbol="K", Name="Potassium", AtomicNumber=19}},
        {"Ca", new() {Symbol="Ca", Name="Calcium", AtomicNumber=20}},
        {"Sc", new() {Symbol="Sc", Name="Scandium", AtomicNumber=21}},
        {"Ti", new() {Symbol="Ti",Name="Titanium", AtomicNumber=22}}
    };
    public static void KeyValueCollections(){
        string symbol = "K";
        Dictionary<string, Element> Elements = BuildDictionary();

        // KeyValuePair - Defines a key/value pair that can be set or retrieved.
        foreach (KeyValuePair<string, Element> kvp in Elements){
            Console.WriteLine("Key " + kvp.Key);
            Console.WriteLine($"Value {kvp.Value.Symbol} {kvp.Value.Name} {kvp.Value.AtomicNumber}");
        }
        
        // ContainsKey method
        if (Elements.ContainsKey(symbol) == false){
            Console.WriteLine($"{symbol} is not present in Elements");
        }
        else{
            Console.WriteLine($"{symbol} is present in Elements and name is{Elements[symbol].Name}");
        }

        // TryGetValue method
        if (Elements.TryGetValue(symbol, out Element? theElement) == false)
            Console.WriteLine($"{symbol} is not present in Elements");
        else
            Console.WriteLine($"{symbol} is present in Elements and name is{Elements[symbol].Name}");
    }
}

public class Element{
    public required string Symbol { get; set; }
    public required string Name { get; set; }
    public required int AtomicNumber { get; set; }
}

