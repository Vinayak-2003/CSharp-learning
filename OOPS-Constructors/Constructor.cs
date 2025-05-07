class Student{
    public int? StudentID { get; set; }
    public string? Name { get; set; }
    public string? College {get; set; }

    // --------------------- default constructor --------------------- //
    public Student(){
        College = "Manipal University Jaipur";
    }

    // --------------------- parameterized constructor --------------------- //
    public Student(int studentId, string name, string college){
        this.StudentID = studentId;
        this.Name = name;
        this.College = college;
    }

    public Student(int studentId, string name){
        this.StudentID = studentId;
        this.Name = name;
    }
}

class Example{
    // --------------------- private constructor --------------------- //
    private static int Counter;
    private Example(){
        Counter = 10;
    }

    public Example(int counter){
        Counter += counter;
    }
    public static int GetCounter(){
        return ++Counter;
    }

    public class NestedExample{                     
        public void Test(){
            // internal instance
            Example example = new Example();
        }
    }

    // --------------------- static constructor --------------------- //
    static Example(){
        Counter = 30;
    }
}

class Program{
    static void Main(){
        // Student student1 = new Student();
        // Console.WriteLine("StudentID: {0}, Name: {1}, College: {2}", student1.StudentID, student1.Name, student1.College);

        // Student student2 = new Student(001, "Vinayak", "MUJ");
        // Console.WriteLine("StudentID: {0}, Name: {1}, College: {2}", student2.StudentID, student2.Name, student2.College);

        // external instance for private constructor is not allowerd
        Example example = new Example(10);
        Console.WriteLine("Counter values is: {0}", Example.GetCounter());
    }
}