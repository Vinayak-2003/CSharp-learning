using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class AsynchronousImplementation
{
    public static async Task Demo()
    {
        var watch = new Stopwatch();
        watch.Start();

        var task1 = FunctionStart();
        var task2 = Processing();
        var task3 = FunctionEnd();
        Console.WriteLine(DateTime.Now.DayOfWeek);
        var hours = await GetHours();
        Console.WriteLine(hours);

        Task.WaitAll(task1, task2, task3);
        watch.Stop();
        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }

    public static async Task FunctionStart()
    {
        await Task.Run(() =>
            {
                Thread.Sleep(8000);                     // milliseconds timeout
                Console.WriteLine("Func start ....");
            }
        );
    }

    public static async Task Processing()
    {
        await Task.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("Processing ....");
            }
        );
    }

    public static async Task<int> GetHours()
    {
        ///
        DayOfWeek today = await Task.FromResult(DateTime.Now.DayOfWeek);
        int leisureHours = today is DayOfWeek.Saturday || today is DayOfWeek.Sunday ? 16 : 5;
        return leisureHours;
    }

    public static async Task FunctionEnd()
    {
        ///
        await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Func end ....");
            }
        );
    }

    public static Task Test()
    {
        Console.WriteLine("Testing");
        return Task.CompletedTask;
    }
}

class Program
{
    public static async Task Main()
    {
        // await AsynchronousImplementation.Demo();

        // await AsyncAwait.MakeTeaAsync();

        await AsyncAwait.StartTask();
    }
}