public static partial class AsyncAwait
{
    public static async Task<string> MakeTeaAsync()
    {
        var boilingWater = BoilWaterAsync();

        Console.WriteLine("Take the cups out");

        var a = 0;
        for (int i = 0; i < 1000000000; i++)
        {
            a += i;
        }

        Console.WriteLine("Put tea in cups");

        var water = await boilingWater;
        string tea = $"Put {water} in cups";
        Console.WriteLine(tea);
        return tea;
    }

    public static async Task<string> BoilWaterAsync()
    {
        Console.WriteLine("Start the kettle");
        Console.WriteLine("Waiting for the kettle");
        await Task.Delay(500);

        Console.WriteLine("Kettle finished boiling");
        return "water";
    }
}