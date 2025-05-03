// --------------- Array --------------- //

using System.Reflection.Metadata.Ecma335;

// --------------- null array --------------- //
int[] numbers = new int[10];
foreach (int element in numbers){
    Console.Write(element + " ");
}
Console.WriteLine("");


// --------------- declare a single dimension --------------- //
int[] array1 = new int[5];
Console.WriteLine(array1.Length);

int[] array2 = [1,2,3,4,5,6,7];
Console.WriteLine(array2.Length);

string[] weekdays = ["Mon", "Tues", "Wed"];
DisplayArray(weekdays);
ReverseArray(weekdays);
DisplayArray(weekdays);

// pass single dimensional array as arguments
static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
static void ReverseArray(string[] arr) => Array.Reverse(arr);

// --------------- declare a multidimension array --------------- //
int[,] multiDimensional1 = new int[2, 3];
Console.WriteLine(multiDimensional1.Length);

int[,] multiDimensional2 = { {1,2,3}, {1,2,3} };
// [ [1,2,3], [1,2,3]] ----> Cannot initialize type 'int[*,*]' with a collection expression because the type is not constructible.
Console.WriteLine(multiDimensional2.Length);


// --------------- jagged array --------------- //
int[][] jaggedArray = new int[3][];
Console.WriteLine(jaggedArray.Length);

jaggedArray[0] = [1,2,3,4,5,6];
jaggedArray[1] = [11,12,13];
jaggedArray[2] = [21,22,23,24];
// jaggedArray[3] = [31,32,33,34,35];

jaggedArray[1][2] = 77;

int[][,] jaggedArray2 = [
    new int[,] { {1,2}, {3,4} },
    new int[,] { {4,5}, {5,6}, {6,7} },
    new int[,] { {6,7}, {7,8} }
];

foreach(Array arr in jaggedArray2){
    foreach(int element in arr){
        Console.Write(element + " ");
    }
    Console.WriteLine();
}