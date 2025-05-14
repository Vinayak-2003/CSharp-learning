public partial class Collections{
    public static void IteratorsCollections(){
        foreach (int n in EvenSequence(5,18)){
            Console.Write($"{n.ToString()} ");
        }
        Console.WriteLine();
    }

    private static IEnumerable<int> EvenSequence(int firstNum, int lastNum){

        for (var num = firstNum; num <= lastNum; num++){
            if (num % 2 == 0){
                yield return num;
            }
        }
    }
}