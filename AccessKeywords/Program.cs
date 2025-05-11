// ------------------------ base ------------------------ //
using System.Linq.Expressions;

public class Person{
    private string ssn = "112233-998877";
    protected string name = "Vinayak";
    private int num;
    public Person() => 
        Console.WriteLine("in Person()");
    public Person(int i){
        num = i;
        Console.WriteLine("in Person(int i)" + (i+100));
    }
    public virtual void GetInfo(){
        Console.WriteLine($"Name {name}");
        Console.WriteLine($"SSN {ssn}");
    }
}
class Employee : Person{
    public readonly string id = "ABC-112233";
    // this constructor will call Person.Person()
    public Employee() : base() {}
    // this constructor will call Person.Person(int i)
    public Employee(int i) : base(i) {
        Console.WriteLine("in Employee(i)" + i);
    }
    public override void GetInfo(){
        base.GetInfo();                         // accessing method from the base class
        Console.WriteLine($"Employee ID {id}");
    }
    private string college;
    private string alias;
    // use this to qualify the fields that are hiding the same name
    public Employee(string college, string alias){
        this.college = college;
        this.alias = alias;
    }
    
    public decimal Salary { get; } = 3000.00m;
    public void printEmployee(){
        Console.WriteLine($"""
        Name = {name}
        College = {college}
        Alias = {alias}
        """);

        // passing object to the method using this
        Console.WriteLine($"Tax to pay {Tax.CalculateTax(this)}");
    }
}

class Tax{
    public static decimal CalculateTax(Employee emp) => 0.08m * emp.Salary;
}

class Program{
    public static void Main(){
        Employee employee = new Employee();
        employee.GetInfo();

        Employee employee1 = new Employee(200);

        Employee employee2 = new Employee("Manipal University", "mpan");
        employee2.printEmployee();

        Employee employee3 = new Employee();
        employee3.printEmployee();
    }
}