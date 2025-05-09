// ----------------- member access expression (.) ----------------- //

// to access nested namespace
// using System.Collections.Generic;

// to form a qualified name
// System.Collections.Generic.IEnumerable<int> numbers = [1,2,3];

// indexer operator
// array
// int[] fib = new int[10];
// fib[0] = fib[1] = 1;
// for (int i=2;i<fib.Length;i++){
//     fib[i] = fib[i-1]+fib[i-2];
// }
// Console.WriteLine("Length :" + fib.Length);
// Console.WriteLine("value for fib[9] is: " + fib[fib.Length-1]);

// indexer
// var dict = new Dictionary<string, double>();
// dict["one"] = 1;
// dict["pi"] = Math.PI;
// Console.WriteLine("Value for 1+Math.PI is: " + (dict["one"] + dict["pi"]));

// null conditional operators

// using Microsoft.VisualBasic;

// namespace NullConditionalExample{
//     class NullConditional{
//         public string? name = null;
//         public void ShowInternalName(string myName){
//             Console.WriteLine(myName);
//         }
//     }

//     class Program{
//         static void Main(string[] args){
//             NullConditional nullConditionalObj = new NullConditional();
//             Console.WriteLine(nullConditionalObj?.name);
//         }
//     }
// }


