using System.Collections;
using System.Reflection.Metadata.Ecma335;
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

class PetOwner
{
    public string? Name { get; set; }
    public List<string>? Pets { get; set; }
}

public class CaseInsensitiveComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return string.Compare(x, y, ignoreCase:true);
    }
}

public static partial class LINQueries
{
    static string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
    static int[] numbers = { 4, 8, 8, 3, 9, 0, 7, 4, 2 };
    static int[] nums = { 111, 222, 333, 444, 8, 3, 9, 0 };
    static double[] floatNums = { 23.01, 11.2, 23.87, 44, 67, 8, 3, 9, 0 };
    static int[] emptyNums = { };
    static ArrayList CombinedArray = new() { "Mango", "apple", 45, null, 23.7, "pineapple", true };
    static List<Pet> petsList = new List<Pet>
    {
        new Pet { Name="Barley", Age=8.3, Owner=p1 },
        new Pet { Name="Boots", Age=4.3, Owner=p2 },
        new Pet { Name="Whiskers", Age=1.5, Owner=p2 },
        new Pet { Name="Daisy", Age=4.4, Owner=p1 }
    };
    static PetOwner[] petOwners = {
        new PetOwner {Name="Kartikeya", Pets=new List<string> {"Scruffy", "Sam"} },
        new PetOwner {Name="Somil", Pets=new List<string> { "Walker", "Sugar" } },
        new PetOwner {Name="Aryan", Pets=new List<string> { "Dusty" } }
    };
    static Person p2 = new Person { Name = "Kartikeya" };
    static Person p1 = new Person { Name = "Vinayak" };
    static List<Person> people = new List<Person> { p1, p2 };
}

class Program
{
    public static void Main()
    {
        LINQueries.AggregateQuery();

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

        // LINQueries.IntersectQuery();

        // LINQueries.JoinQuery();

        // LINQueries.LastQuery();

        // LINQueries.lastOrDefaultQuery();

        // LINQueries.LongCountQuery();

        // LINQueries.MaxQuery();

        // LINQueries.MinQuery();

        // LINQueries.OfTypeQuery();

        // LINQueries.OrderQuery();

        // LINQueries.OrderDescendingQuery();

        // LINQueries.PrependQuery();

        // LINQueries.RangeQuery();

        // LINQueries.RepeatQuery();

        // LINQueries.ReverseQuery();

        // LINQueries.SelectQuery();

        // LINQueries.SelectManyQuery();

        // LINQueries.SequeneceEqual();

        // LINQueries.SingleQuery();

        // LINQueries.SingleOrDefaultQuery();

        // LINQueries.SkipQuery();

        // LINQueries.SkipLastQuery();

        // LINQueries.SkipWhileQuery();

        // LINQueries.SumQuery();

        // LINQueries.TakeQuery();

        // LINQueries.TakeLastQuery();

        // LINQueries.TakeWhileQuery();

        // LINQueries.ThenByQuery();

        // LINQueries.ThenByDescendingQuery();

        // LINQueries.ToArrayQuery();

        // LINQueries.ToDictionaryQuery();

        // LINQueries.ToHashSetQuery();

        // LINQueries.ToListQuery();

        // LINQueries.ToLookupQuery();

        // LINQueries.TryGetNonEnumeratedCountQuery();

        // LINQueries.UnionQuery();

        // LINQueries.WhereQuery();
        
        // LINQueries.ZipQuery();
    }
}