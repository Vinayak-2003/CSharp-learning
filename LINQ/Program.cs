// int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

// var numQuery = from num in numbers
//                 where (num % 2) == 0
//                 select num;

// foreach (int num in numQuery)
// {
//     Console.Write(num + " ");
// }
using System.Security.Cryptography.X509Certificates;

class Pet
{
    public string? Name { get; set; }
    public double Age { get; set; }
    public Person? Owner { get; set; }
}

class Person
{
    public string? Name { get; set; }
}

public static partial class LINQueries
{
    static string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
    static int[] numbers = { 4, 8, 8, 3, 9, 0, 7, 4, 2 };
    static int[] nums = { 111, 222, 333, 444, 8, 3, 9, 0 };
    static double[] floatNums = { 23.01, 11.2, 23.87, 44, 67, 8, 3, 9, 0 };
    static int[] emptyNums = { };
    static List<Pet> petsList = new List<Pet>
    {
        new Pet { Name="Barley", Age=8.3, Owner=p1 },
        new Pet { Name="Boots", Age=4.3, Owner=p2 },
        new Pet { Name="Whiskers", Age=1.5, Owner=p2 },
        new Pet { Name="Daisy", Age=4.3, Owner=p1 }
    };
    static Person p2 = new Person { Name = "Kartikeya" };
    static Person p1 = new Person { Name = "Vinayak" };
    static List<Person> people = new List<Person> { p1, p2 };
}

class Program
{
    public static void Main()
    {
        // LINQueries.AggregateQuery();

        // LINQueries.AllQuery();

        // LINQueries.AnyQuery();

        // LINQueries.AppendQuery();

        // LINQueries.AsEnumerableQuery()

        // LINQueries.AverageQuery();

        // LINQueries.CastQuery();

        // LINQueries.ChunkQuery();

        // LINQueries.ConcatQuery();

        // LINQueries.ContainsQuery();

        // LINQueries.CountQuery();

        // LINQueries.DefaultIfEmptyQuery();

        // LINQueries.DistinctQuery();

        // LINQueries.ElementAtQuery();

        // LINQueries.ElementsAtOrDefault();

        // LINQueries.EmptyQuery();

        // LINQueries.ExceptQuery();

        // LINQueries.FirstQuery();

        // LINQueries.FirstOrDefaultQuery();

        // LINQueries.GroupByQuery();

        // LINQueries.IndexQuery();
    }
}