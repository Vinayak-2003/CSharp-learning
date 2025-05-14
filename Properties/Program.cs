public class Person{
    public string? FirstName { get; set; } = String.Empty;

    public string? LastName {
        get;
        set => field = value.Trim();
    }

    public Person() {}
    
}