using System.Collections.Concurrent;

public class GenericList<T>{
    public void Add(T item) { }
}

public class ExampleClass { }

// linked list
public class GenericLinkedList<L>{
    private class Node(L l){
        public L Data { get; set; } = l;
        public Node? Next { get; set; }
    }

    // first item in the linked list
    private Node? head;

    // L as parameter type
    public void AddHead(L l){
        Node n = new(l);
        n.Next = head;
        head = n;
    }

    // L in method return type
    public IEnumerable<L> GetEnumerator(){
        Node? current = head;
        while (current is not null){
            yield return current.Data;
            current = current.Next;
        }
    }
}

public class ClsEqual
{
    public static bool AreEqual<T>(T val1, T val2)
    {
        return val1.Equals(val2);
    }
}


// generic as class-type
class MyGenericClass<T>
{
    // generic as field data-type
    private T? GenericMemebrValue;
    // generic as class parameter 
    public MyGenericClass(T value)
    {
        GenericMemebrValue = value;
    }
    // 
    public T GenericMethod(T GenericParam)
    {
        Console.WriteLine($"Parameter type {typeof(T).ToString()}, Value: {GenericParam}");
        Console.WriteLine($"Return type {typeof(T).ToString()}, Value: {GenericMemebrValue}");
        return GenericMemebrValue;
    }
    public T GenericProperty { get; set; }
}


class Program{
    private static void Main()
    {
        GenericList<int> integerList = new GenericList<int>();
        integerList.Add(1);

        GenericList<string> stringList = new();
        stringList.Add("Vinayak");

        GenericList<ExampleClass> exampleClass = new();
        exampleClass.Add(new ExampleClass());

        GenericLinkedList<int> genericLinkedList = new();
        for (int x = 10; x < 10; x++)
        {
            genericLinkedList.AddHead(x);
        }

        bool IsEqual = ClsEqual.AreEqual<double>(10.5, 10.5);
        if (IsEqual)
        {
            Console.WriteLine("values are equal");
        }
        else
        {
            Console.WriteLine("values are not equal");
        }

        MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
        int val = intGenericClass.GenericMethod(200);
        Console.WriteLine(val);

        ListImplementation.ListOps();

        MultipleTypeGeneric<string, int> multiGeneric = new MultipleTypeGeneric<string, int>();
        multiGeneric.Message = "Hello world!!";
        multiGeneric.MultiGenericMethod("Vinayak", 43);

        RestrictGeneric<bool> restrictedGeneric = new RestrictGeneric<bool>();
        int num = 23;
        bool condition = true;
        restrictedGeneric.IntFloatMethod(condition);
    }
}