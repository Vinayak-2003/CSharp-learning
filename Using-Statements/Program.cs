using System;

class Program{
    public static void func(double a){

    }
    public static void func(long a){

    }
    
    public static void Main(){
        var numbers = new List<int>();
        using (StreamReader reader = File.OpenText("numbers.txt")){
            string? line;
            while ((line = reader.ReadLine()) is not null){
                if(int.TryParse(line, out int number)){
                    numbers.Add(number);
                }
            }
            func(5.6);
        }
        // Console.WriteLine("Numbers {0}", string.Join(" ", numbers));
        for (int i=0;i<numbers.Count;i++){
            Console.Write($"{numbers[i]} ");
        }
    }
}
