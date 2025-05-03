using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Text.Json.Nodes;

// declaring a string without initializing
string name;
// Console.WriteLine(name);

// initialize a string
string message = "Hello !!";
System.String greets = "Bonjour !!";
Console.WriteLine(message + greets);

// initialize a null string
string? null_message = null;
Console.WriteLine("Null string -> " + null_message);

// initialize an empty string
string empty_message = System.String.Empty;
Console.WriteLine("Empty string -> " + empty_message);

// initialize with a regular string literal
string oldPath = "C:\\Users\\VinayakKanchan\\Desktop\\Programming\\C#\\Strings\\strings.cs";
Console.WriteLine(oldPath);

// initialize with a verbatim string literal
string newPath = @"C:\Users\VinayakKanchan\Desktop\Programming\C#\Strings\strings.cs";
Console.WriteLine(newPath);

// initialize in a local variable (i.e within a method)
var temp = "I'm still a strongly-typed System.String!";
Console.WriteLine(temp);

// initialize using const to prevent being use to another string
const string message2 = "I am learning C#";
Console.WriteLine(message2);

// initialize 
char[] letters = {'A', 'B', 'C'};
string alphabet = new string(letters);
Console.WriteLine("Letters -> " + letters + " type -> " + letters.GetType());
Console.WriteLine("Alphabets -> " + alphabet + " type -> " + alphabet.GetType());


// string concatenation and craeted in a different memory 
unsafe{
    string greetings = "Bonjour !! ";
    string myName = "Vinayak";

    // You cannot use the & operator to get their address unless you pin them using fixed.
    fixed (char* greetings_address = greetings){
        Console.WriteLine("Greetings address " + (IntPtr)greetings_address);
    }
    fixed (char* myName_address = myName){
        Console.WriteLine("Name address " + (IntPtr)myName_address);
    }

    greetings += myName;
    fixed (char* updated_greetings_address = greetings){
        Console.WriteLine("Updated greetings address " + (IntPtr)updated_greetings_address);
    }
    Console.WriteLine(greetings);
}


// ---------------- Verbatim strings ---------------- //
string newPath2 = @"C:\Users\VinayakKanchan\Desktop\Programming\C#\Strings\strings.cs";
Console.WriteLine(newPath2);

string paragraph = @"Hello, my name is Vinayak !
I am a developer ""Trainee"" at Celebal Technologies
I am learning C#";
Console.WriteLine(paragraph);


// ---------------- Raw strings literals ---------------- //
string singleLine = """ "Hello" Friends """;
Console.WriteLine(singleLine);

string multiLine = """
Hello, my name is Vinayak 
   I am a developer "Trainee" at Celebal Technologies
I am learning C# 
""";
Console.WriteLine(multiLine);


// ---------------- String interpolation ---------------- //
var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
name = "Vinayak";

Console.WriteLine($"{message} {name} Kanchan");
Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");

// ---------------- raw string interpolation ---------------- //
int x = 2, y = 3, z = 9;
var pointMessage = $$"""The point {> {{{x}}} , {{y}} , {{z}} <} from origin.""";
Console.WriteLine(pointMessage);

// ---------------- verbatim string interpolation ---------------- //
Console.WriteLine(@$"{{{jh.firstName}}} is a planet");

// ---------------- composite formatting ---------------- //
Console.WriteLine("{0} is lastname", jh.lastName);


// ---------------- Substring ---------------- //
string s3 = "Visual Studio Code for C#";
Console.WriteLine(s3.Substring(3, 5));
Console.WriteLine(s3.IndexOf("u"));
Console.WriteLine(s3.Replace("Code", "Basic Code"));

for (int i = 0; i<s3.Length; i++){
    Console.Write(s3[s3.Length-i-1]);       // print reverse string
}
Console.WriteLine("");


// ---------------- StringBuilder ---------------- //
string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
System.Text.StringBuilder answer = new System.Text.StringBuilder(question);

for (int i = 0; i<answer.Length; i++){
    if (Char.IsLower(answer[i]) == true)
        answer[i] = System.Char.ToUpper(answer[i]);
    else if(System.Char.IsUpper(answer[i]) == true)
        answer[i] = System.Char.ToLower(answer[i]);
}

Console.WriteLine(question.GetType());
Console.WriteLine(answer.GetType());
string corrected = answer.ToString();
Console.WriteLine(corrected.GetType());
Console.WriteLine(corrected);