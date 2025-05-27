using Microsoft.VisualBasic;

class LambdaFunction
{
    public Func<int, int> Square = x => x * x;

    // implicit type
    public Func<int, int, bool> EqualityTest = (x, y) => x == y;

    // explicit type
    public Func<int, string, bool> IsTooLong = (int x, string s) => s.Length > x;

    public Func<IEnumerable<int>, int> Sum = values =>
    {
        int sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }
        return sum;
    };

    // lambda function and tuples
    public Func<(int, int, int), (int, int, int)> DoubleLambda = nums => (
        2 * nums.Item1, 2 * nums.Item2, 2 * nums.Item3
    );
    
    Action name = () =>
    {
        Console.WriteLine("Vinayak");
    };
}

class Program{
    public static void Main(){
        LambdaFunction lambda = new LambdaFunction();
        int ans = lambda.Square(3);
        Console.WriteLine(ans);

        bool equalAns = lambda.EqualityTest(2,3);
        Console.WriteLine(equalAns);

        bool isLongAns = lambda.IsTooLong(3, "hello");
        Console.WriteLine(isLongAns);

        // lambda function with params arrays or collections
        var ParamsSum = (params IEnumerable<int> values) => {
            int sum = 0;
            foreach (var value in values){
                sum += value;
            }
            return sum;
        };

        var sequence = new[] {1,2,4,5,6,7,8};
        var total = lambda.Sum(sequence);
        Console.WriteLine(total);

        var empty = ParamsSum();
        Console.WriteLine(empty);

        var numbers = (2,3,4);
        var doubleNums = lambda.DoubleLambda(numbers);
        Console.WriteLine(doubleNums);
    }
}