using System.Diagnostics;
using System.Threading.Tasks;

public static partial class AsyncAwait
{
    public async static Task StartTask()
    {
        var watch = new Stopwatch();
        watch.Start();

        Console.WriteLine("Start .....");

        // as cleaning house and cook food function is not dependent on wash and dry clothes
        Task task1 = WashAndDryClothes();
        // Task task2 = CleanHouse();
        // Task task3 = CookFood();

        Task task2 = Task.Run(() => CleanHouse());
        Task task3 = Task.Run(() => CookFood());

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("End .....");

        watch.Stop();
        Console.WriteLine($"Elapsed time: {watch.ElapsedMilliseconds} ms");
    }

    public static async Task WashAndDryClothes()
    {
        string clothes = await WashClothes();
        Task task1 = DryClothes(clothes);
    }

    public async static Task<string> WashClothes()
    {
        Console.WriteLine("Start washing clothes .....");
        // Task.Delay(1000).Wait();                             // waits synchronously
        await Task.Delay(1000);
        Console.WriteLine("end washing clothes .....");
        return "Wet clothes";
    }

    public async static Task DryClothes(string clothes)
    {
        Console.WriteLine("Start drying clothes .....");
        // Task.Delay(1000).Wait();                             // waits synchronously
        await Task.Delay(1000);
        Console.WriteLine("end drying clothes .....");
    }

    public static async Task CleanHouse()
    {
        Console.WriteLine("Start cleaning house .....");
        // Task.Delay(2000).Wait();                             // waits synchronously
        await Task.Delay(2000);
        Console.WriteLine("end cleaning house .....");
    }

    public static async Task CookFood()
    {
        Console.WriteLine("Start Cooking Food .....");
        // Task.Delay(2000).Wait();                             // waits synchronously
        await Task.Delay(2000);
        Console.WriteLine("end Cooking Food .....");
    }
}