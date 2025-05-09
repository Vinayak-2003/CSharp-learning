using System.Reflection;
using Microsoft.VisualBasic;

double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetNum){
    return setsOfNumbers?[indexOfSetNum]?.Sum() ?? double.NaN;

    // this gives the error for null
    // return setsOfNumbers[indexOfSetNum].Sum();
}

var sum1 = SumNumbers(null, 0);
Console.WriteLine(sum1);

List<double[]> numberSets = [
    [2.0, 5.0, 7.0],
    null
];

var sum2 = SumNumbers(numberSets, 0);
Console.WriteLine(sum2);

var sum3 = SumNumbers(numberSets, 1);
Console.WriteLine(sum3);

// ------------------------------------------------------------- //

int getSumOfFirstTwoOrDefault(int[] numbers){
    if ((numbers?.Length ?? 0) < 2){
        return 0;
    }
    return numbers[0] + numbers[1];
}

Console.WriteLine(getSumOfFirstTwoOrDefault(null));
Console.WriteLine(getSumOfFirstTwoOrDefault([1]));
Console.WriteLine(getSumOfFirstTwoOrDefault([3,5,7]));

string[] nums = new string[5];
nums[4] = "five";
Console.WriteLine("nums[5]: {0}", nums[4]);


// ----------------- Index from end operator ^ ----------------- //
int[] numsArray = [12,45,32,64,43,76,54,23];
Console.WriteLine(numsArray[^1]);

// ----------------- range operator ----------------- //
int start = 1;
int end = 6;
int[] subset = numsArray[start .. end];
Display(subset);

int[] subset2 = numsArray[start .. ^start];
Display(subset2);

string topicName = "Member Access And Null Conditional Operators";
int fromEnd = 12;


void Display(int[] arr){
    for (int i=0;i<arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}