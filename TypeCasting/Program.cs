namespace TypeCasting{

    class Program{
        static void Main(string[] args){
            int i = 23;
            Console.WriteLine(i);

            long j = i;
            Console.WriteLine(j);

            char ch = (char)i;
            Console.WriteLine(ch);

            string st = i.ToString();
            Console.WriteLine(st);

            if (i is int s){
                Console.WriteLine(s+4);
            }
        }
    }
}