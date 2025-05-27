using System.Data;

public class RestrictGeneric<T> where T : struct
{
    public T property;
    public RestrictGeneric()
    {
        if (typeof(T) != typeof(int) && typeof(T) != typeof(float))
        {
            throw new InvalidConstraintException("Only int and double is supported !!");
        }
    }

    public void IntFloatMethod(T number)
    {
        Console.WriteLine($"Restricted Int Float Generic: {number}");
    }
}