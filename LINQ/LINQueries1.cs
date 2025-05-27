using System.Collections;
using System.Dynamic;
using System.Globalization;
using System.Numerics;
using System.Security.Claims;
using System.Transactions;

public static partial class LINQueries
{
    public static void AggregateQuery()
    {
        string longestName = fruits.Aggregate("banana",
                                            (longest, next) =>
                                                next.Length > longest.Length ? next : longest,
                                            fruit => fruit.ToUpper());

        Console.WriteLine($"Fruit with longest name other than banana is {longestName}");

        int evenSum = numbers.Aggregate(0, (total, next) =>
                                                next % 2 == 0 ? total + next : total);

        Console.WriteLine($"Sum of event numbers is {evenSum}");
    }

    public static void AllQuery()
    {
        bool allStartsWithB = fruits.All(fruit => fruit.StartsWith("a"));
        Console.WriteLine("{0} fruit names starts with a", allStartsWithB ? "All" : "NotAll");
    }

    public static void AnyQuery()
    {
        bool allStartsWithB = fruits.Any(fruit => fruit.StartsWith("a"));
        Console.WriteLine("{0} any fruit name starts with a", allStartsWithB ? "Yes" : "No");
    }

    public static void AppendQuery()
    {
        numbers.Append(112);

        // does not affect the original list / array
        Console.WriteLine(string.Join(", ", numbers));

        // works now as we are using changed copy of the original list / array
        Console.WriteLine(string.Join(", ", numbers.Append(121)));
    }

    public static void AsEnumerableQuery()
    {
        List<string> fruitClump = new List<string> { "apple", "passionfruit", "banana",
            "mango", "orange", "blueberry", "grape", "strawberry" };

        IEnumerable<string> query1 = fruitClump.Where(fruit => fruit.Contains("o"));
    }

    public static void AverageQuery()
    {
        float? average = (float)numbers.Average();

        Console.WriteLine($"The average of numbers is {average}");
    }

    public static void CastQuery()
    {
        ArrayList castFruits = new ArrayList();
        castFruits.Add("Apple");
        castFruits.Add("Mango");
        castFruits.Add("Grapes");
        IEnumerable<string> query = castFruits.Cast<string>();
        foreach (string fruit in castFruits)
        {
            Console.WriteLine(fruit);
        }
    }

    public static void ChunkQuery()
    {
        var chunks = fruits.Chunk<string>(2);

        foreach (var c in chunks)
        {
            Console.WriteLine(string.Join(", ", c));
        }
    }

    public static void ConcatQuery()
    {
        var concatList = floatNums.Concat(numbers.Select(n => (double)n));

        foreach (var c in concatList)
        {
            Console.Write(c + " ");
        }
    }

    public static void ContainsQuery()
    {
        bool checkFruit = fruits.Contains("apple");
        Console.WriteLine(checkFruit);
    }

    public static void CountQuery()
    {
        int numOfFruits = fruits.Count();
        Console.WriteLine(numOfFruits);
    }

    public static void DefaultIfEmptyQuery()
    {
        foreach (int n in emptyNums.DefaultIfEmpty())
        {
            Console.Write("Empty list: " + n);
        }
        Console.WriteLine();
        foreach (int n in numbers.DefaultIfEmpty())
        {
            Console.Write(n + " ");
        }
    }

    public static void DistinctQuery()
    {
        IEnumerable distinctNums = numbers.Distinct();
        foreach (int n in distinctNums)
        {
            Console.Write(n + " ");
        }
    }

    public static void ElementAtQuery()
    {
        string fName = fruits.ElementAt(5);
        Console.WriteLine(fName);
    }

    public static void ElementsAtOrDefault()
    {
        string? fName = fruits.ElementAtOrDefault(5);
        Console.WriteLine(fName);
    }

    public static void EmptyQuery()
    {
        IEnumerable<string> empty = Enumerable.Empty<string>();
        foreach (string n in empty)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        string[] names1 = { "Hartono, Tommy" };
        string[] names2 = { "Adams, Terry", "Andersen, Henriette Thaulow",
                            "Hedlund, Magnus", "Ito, Shu" };
        string[] names3 = { "Solanki, Ajay", "Hoeing, Helge",
                            "Andersen, Henriette Thaulow",
                            "Potra, Cristina", "Iallo, Lucio" };

        List<string[]> namesList = new List<string[]> { names1, names2, names3 };

        IEnumerable<string> allNames = namesList.Aggregate(Enumerable.Empty<string>(), (current, next) => next.Length > 3
                                                            ? current.Union(next) : current);

        foreach (string name in allNames)
        {
            Console.Write(name + " ");
        }
    }

    public static void ExceptQuery()
    {
        IEnumerable onlySet = numbers.Except(nums);
        foreach (int n in onlySet)
        {
            Console.Write(n + " ");
        }
    }

    public static void FirstQuery()
    {
        int firstNum = nums.First();
        int firstGreaterNum = numbers.First(num => num > 7);
        Console.WriteLine(firstGreaterNum);
    }

    public static void FirstOrDefaultQuery()
    {
        int firstGreaterNum = numbers.FirstOrDefault(num => num > 9);
        Console.WriteLine(firstGreaterNum);
    }

    public static void GroupByQuery()
    {
        // Group Pet.Age values by the Math.Floor of the age. Then project an anonymous type from each group
        // that consists of the key, the count of the group's elements, and the minimum and maximum age in the group.
        var groupByQuery = petsList.GroupBy(pet => Math.Floor(pet.Age), pet => pet.Age, (baseAge, ages) => new
        {
            Key = baseAge,
            Count = ages.Count(),
            Min = ages.Min(),
            Max = ages.Max()
        });

        foreach (var result in groupByQuery)
        {
            Console.WriteLine("\nAge group: " + result.Key);
            Console.WriteLine("Number of pets in this age group: " + result.Count);
            Console.WriteLine("Minimum age: " + result.Min);
            Console.WriteLine("Maximum age: " + result.Max);
        }

        // Group the pets using Age as the key value and selecting only the pet's Name for each value.
        IEnumerable<IGrouping<double, string?>> query = petsList.GroupBy(pet => pet.Age, pet => pet.Name);
        foreach (IGrouping<double, string?> pet in query)
        {
            Console.WriteLine(pet.Key);
            foreach (string? name in pet)
            {
                Console.WriteLine(" {0}", name);
            }
        }
    }

    public static void GroupJoinQuery()
    {
        var query = people.GroupJoin(petsList,
                                        person => person,
                                        pet => pet.Owner,
                                        (person, petCollection) =>
                                        new
                                        {
                                            ownerName = person.Name,
                                            pets = petCollection.Select(pet => pet.Name)
                                        });

        foreach (var obj in query)
        {
            Console.WriteLine("{0}", obj.ownerName);
            foreach (string? pet in obj.pets)
            {
                Console.WriteLine(" {0}", pet);
            }
        }
    }

    public static void IndexQuery()
    {
        var indexedPetList = petsList.Index();
        foreach (var (idx, pet) in indexedPetList)
        {
            Console.WriteLine($"Index {idx} => Pet Name {pet.Name} ");
        }
    }

    
}