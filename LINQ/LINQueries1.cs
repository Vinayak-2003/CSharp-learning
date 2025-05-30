using System.Collections;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Globalization;
using System.Numerics;
using System.Security.Claims;
using System.Security.Cryptography;
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

    public static void IntersectQuery()
    {
        IEnumerable<int> commonNums = numbers.Intersect(nums);
        foreach (int n in commonNums)
        {
            Console.Write(n + " ");
        }
    }

    public static void JoinQuery()
    {
        // Create a list of Person-Pet pairs where each element is an anonymous type that contains a
        // Pet's name and the name of the Person that owns the Pet.
        var joinData = people.Join(petsList,
                                    person => person,
                                    pet => pet.Owner,
                                    (person, pet) =>
                                        new { ownerName = person.Name, petName = pet.Name });
        // Console.WriteLine(joinData);
        foreach (var obj in joinData)
        {
            Console.WriteLine("{0} - {1}", obj.ownerName, obj.petName);
        }
    }

    public static void LastQuery()
    {
        int lastNum = numbers.Last();
        Console.WriteLine($"Last number is {lastNum}");

        int lastCondNum = numbers.Last(num => num > 5);
        Console.WriteLine($"Last number num > 5 is {lastCondNum}");
    }

    public static void lastOrDefaultQuery()
    {
        int lastCondNum = numbers.LastOrDefault(num => num > 10);
        Console.WriteLine($"Last number num > 10 is {lastCondNum}");

        int defaultNum = numbers.LastOrDefault(num => num > 10) == 0 ? 100 : numbers.LastOrDefault(num => num > 10);
        Console.WriteLine($"Last number num > 10 is {defaultNum}");
    }

    public static void LongCountQuery()
    {
        const int age = 3;
        long count = petsList.LongCount(petAgeCNt => petAgeCNt.Age > age);
        Console.Write($"long count of pet age {count}");
    }

    public static void MaxQuery()
    {
        double? maxNum = floatNums.Max();
        Console.WriteLine($"maximum number is {maxNum}");

        int? maxPet = petsList.Max(pet => (int)pet.Age + pet.Name?.Length);
        Console.WriteLine($"maximum pet sum is {maxPet}");

        Pet? max = petsList.MaxBy(age => age.Age);
        Console.WriteLine($"maximum pet {max?.Name}");
    }

    public static void MinQuery()
    {
        double? maxNum = floatNums.Min();
        Console.WriteLine($"Minimum number is {maxNum}");

        int? maxPet = petsList.Min(pet => (int)pet.Age + pet.Name?.Length);
        Console.WriteLine($"Minimum pet sum is {maxPet}");

        Pet? max = petsList.MinBy(age => age.Age);
        Console.WriteLine($"Minimum pet {max?.Name}");
    }

    public static void OfTypeQuery()
    {
        IEnumerable<string> onlyStrings = CombinedArray.OfType<string>();
        foreach (string str in onlyStrings)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();

        IEnumerable<string> conditionalString = CombinedArray.OfType<string>().Where(fruit =>
                                                    fruit.Contains("p"));
        foreach (string str in conditionalString)
        {
            Console.Write(str + " ");
        }
    }

    public static void OrderQuery()
    {
        IEnumerable<string> orderedFruits = fruits.Order();
        foreach (string str in orderedFruits)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();

        IEnumerable<Pet> orderedPets = petsList.OrderBy(pet => pet.Age);
        foreach (Pet pet in orderedPets)
        {
            Console.WriteLine("{0} - {1}", pet.Name, pet.Age);
        }
    }

    public static void OrderDescendingQuery()
    {
        IEnumerable<string> orderedFruits = fruits.OrderDescending();
        foreach (string str in orderedFruits)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();

        IEnumerable<Pet> orderedPets = petsList.OrderByDescending(pet => pet.Age);
        foreach (Pet pet in orderedPets)
        {
            Console.WriteLine("{0} - {1}", pet.Name, pet.Age);
        }
    }

    public static void PrependQuery()
    {
        numbers.Prepend(111);
        Console.WriteLine(string.Join(", ", numbers));

        IEnumerable<int> updatedNumbers = numbers.Prepend(222);
        Console.WriteLine(string.Join(", ", updatedNumbers));
    }

    public static void RangeQuery()
    {
        IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
        foreach (int sq in squares)
        {
            Console.Write(sq + " ");
        }
    }

    public static void RepeatQuery()
    {
        IEnumerable<string> strings = Enumerable.Repeat("Learning C#", 7);
        foreach (string str in strings)
        {
            Console.WriteLine(str);
        }
    }

    public static void ReverseQuery()
    {
        int[] reversedArray = nums.Reverse().ToArray();
        foreach (int rev in reversedArray)
        {
            Console.Write(rev + " ");
        }
    }

    public static void SelectQuery()
    {
        var selectFruits = fruits.Select((fruit, index) =>
                        new { index, str = fruit.Substring(0, index) });

        foreach (var obj in selectFruits)
        {
            Console.WriteLine("{0}", obj);
        }
    }

    public static void SelectManyQuery()
    {
        var manyPets = petOwners.SelectMany(petOwner => petOwner.Pets,
                                    (petOwner, petName) => new { petOwner, petName })
                                    .Where(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
                                    .Select(ownerAndPet =>
                                        new
                                        {
                                            Owner = ownerAndPet.petOwner.Name,
                                            Pet = ownerAndPet.petName
                                        }
        );

        IEnumerable<string> query = petOwners.SelectMany(petOwner => petOwner.Pets);

        foreach (var obj in query)
        {
            Console.WriteLine(obj);
        }
    }

    public static void SequeneceEqual()
    {
        bool isSeqEqual = numbers.SequenceEqual(nums);
        Console.WriteLine("numers and nums are {0}", isSeqEqual ? "Equal" : "Not Equal");
    }

    public static void SingleQuery()
    {
        try
        {
            string singleFruit = fruits.Single(fruit => fruit.Length > 6);
            Console.WriteLine("Single Fruit that satisfies the conditions is " + singleFruit);
        }
        catch (System.InvalidOperationException)
        {
            Console.WriteLine("The collection does not contain exactly one element whose length is greater than 6.");
        }

        try
        {
            int singleNum = emptyNums.Single();
            Console.WriteLine("Single number that satisfies the conditions is " + singleNum);
        }
        catch (System.InvalidOperationException)
        {
            Console.WriteLine("The collection does not contain exactly one element.");
        }
    }

    public static void SingleOrDefaultQuery()
    {
        string? singleFruit = fruits.SingleOrDefault(fruit => fruit.Length > 6);
        Console.WriteLine("Single Fruit that satisfies the conditions is " + singleFruit);

        int singleNum = emptyNums.Single();
        Console.WriteLine("Single number that satisfies the conditions is " + singleNum);
    }

    public static void SkipQuery()
    {
        foreach (int n in numbers.Skip(4))
        {
            Console.Write(n + " ");
        }
    }

    public static void SkipLastQuery()
    {
        foreach (int n in numbers.SkipLast(4))
        {
            Console.Write(n + " ");
        }
    }

    public static void SkipWhileQuery()
    {
        IEnumerable<int> GreaterNums = numbers.SkipWhile(num => num < 9);
        foreach (int num in GreaterNums)
        {
            Console.Write(num + " ");
        }
    }

    public static void SumQuery()
    {
        int sum = numbers.Sum();
        Console.WriteLine($"Total sum is {sum}");
    }

    public static void TakeQuery()
    {
        IEnumerable<int> takeTopThree = numbers.OrderByDescending(num => num).Take(3);
        foreach (int num in takeTopThree)
        {
            Console.Write(num + " ");
        }
    }

    public static void TakeLastQuery()
    {
        foreach (int n in numbers.TakeLast(3))
        {
            Console.Write(n + " ");
        }
    }

    public static void TakeWhileQuery()
    {
        IEnumerable<int> takeWhileNums = numbers.TakeWhile(num => num < 9);
        foreach (int n in takeWhileNums)
        {
            Console.Write(n + " ");
        }
    }

    public static void ThenByQuery()
    {
        // Sort the strings first by their length and then alphabetically by passing the identity selector function.
        IEnumerable<string> arrangeByLength = fruits.OrderBy(fruit => fruit.Length).ThenBy(fruit => fruit);
        foreach (string fruit in arrangeByLength)
        {
            Console.Write(fruit + " ");
        }
    }

    public static void ThenByDescendingQuery()
    {
        string[] fruits = { "apPLe", "baNanA", "apple", "APple", "orange", "BAnana", "ORANGE", "apPLE" };

        IEnumerable<string> arrageByDescendingLength = fruits.OrderBy(fruit => fruit.Length)
                                        .ThenByDescending(fruit => fruit, new CaseInsensitiveComparer());
        foreach (string fruit in arrageByDescendingLength)
        {
            Console.Write(fruit + " ");
        }
    }

    public static void ToArrayQuery()
    {
        Pet[] pets = petsList.Select(pet => pet).ToArray();
        foreach (Pet pet in pets)
        {
            Console.Write(pet.Name + " ");
        }
    }

    public static void ToDictionaryQuery()
    {
        Dictionary<double, Pet> PetDictionary = petsList.ToDictionary(pet => pet.Age);
        foreach (KeyValuePair<double, Pet> kvp in PetDictionary)
        {
            Console.WriteLine("Key {0}: {1}", kvp.Key, kvp.Value.Name);
        }
    }

    public static void ToHashSetQuery()
    {
        HashSet<int> numbersHashSet = numbers.ToHashSet();
        foreach (int n in numbersHashSet)
        {
            Console.Write(n + " ");
        }
    }

    public static void ToListQuery()
    {
        List<string> fruitsList = fruits.Select(fruit => fruit).ToList();
        foreach (string fruit in fruitsList)
        {
            Console.Write(fruit + " ");
        }
    }

    public static void ToLookupQuery()
    {
        Lookup<char, string> petlistLookup = (Lookup<char, string>)petsList.ToLookup(p => p?.Name?[0], p => p.Name);
        foreach (IGrouping<char, string> petGroup in petlistLookup)
        {
            Console.WriteLine(petGroup.Key);
            foreach (string name in petGroup)
            {
                Console.WriteLine("  {0}", name);
            }
        }
    }

    public static void TryGetNonEnumeratedCountQuery()
    {
        var getCount = numbers.TryGetNonEnumeratedCount(out int count);
        Console.WriteLine(getCount);
    }

    public static void UnionQuery()
    {
        IEnumerable numberUnion = numbers.Union(nums);
        foreach (int n in numberUnion)
        {
            Console.Write(n + " ");
        }
    }

    public static void WhereQuery()
    {
        IEnumerable<string> fruitsOfLen = fruits.Where(fruit => fruit.Length < 6);
        foreach (string fruit in fruitsOfLen)
        {
            Console.Write(fruit + " ");
        }
    }

    public static void ZipQuery()
    {
        var numbersAndWords = numbers.Zip(fruits, (first, second) => first + " " + second);
        foreach (var item in numbersAndWords)
        {
            Console.WriteLine(item + " ");
        }
    }
}