public class MultipleTypeGeneric<T, L>
{
    public T? Message;
    public void MultiGenericMethod(T Str, L Number)
    {
        Console.WriteLine($"""
        Name = {Str}
        Message = {Message}
        Number = {Number}
        """);
    }
}