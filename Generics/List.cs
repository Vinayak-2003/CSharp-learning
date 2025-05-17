class ListImplementation{
    public static void ListOps(){
        List<int> list = new List<int>();

        list.Add(12);
        list.Add(20);
        list.Add(32);
        list.Add(54);

        foreach (int n in list){
            Console.Write(n + " ");
        }
        Console.WriteLine();
        
        // Gets or sets the total number of elements the internal data structure can hold without resizing.
        Console.WriteLine($"Capacity of List data structure without resizing " + list.Capacity);
        Console.WriteLine($"Count of the number of elements: {list.Count}");
    }
}