namespace CalculateDelegateNamespace
{
        class CalculatorDelegate{
            public delegate void AddNum(int a, int b);
            public delegate void SubNum(int a, int b);

            public void Sum(int a, int b){
                Console.WriteLine($"{a} + {b} is {a+b}");
            }
            public void Sub(int a, int b){
                Console.WriteLine($"{a} - {b} is {a-b}");
            }
        }
}