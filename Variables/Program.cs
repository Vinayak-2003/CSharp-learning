using System.IO.Enumeration;

namespace Variables{
    // ----------------------- local variables ----------------------- //
    class LocalVariables{
        public void Age(){
            int age = 0;
            age += 10;
            Console.WriteLine("Local variable - age is {0}", age);
        }
    }

    // ----------------------- Instance or non-static variables ----------------------- //
    class InstanceVariables{
        public int mathsMarks;
        public int engMarks;
        public int scienceMarks;
    }

    // ----------------------- Static or class variables  ----------------------- //
    class StaticVariables{
        public static double EmpSalary;
        public static string? EmpName;
    }
    // ----------------------- Constant variables ----------------------- //
    class ConstantVariables{
        public const string fileName = "Variables/Program";
        public readonly string variableType = "Readonly Variable";
    }

    // ----------------------- Readonly variables ----------------------- //
    class ReadonlyVariables{
        public readonly string variableType = "Readonly Variable";
    }

    class Program{
        public static void Main(){
            LocalVariables localVarObj = new LocalVariables();
            localVarObj.Age();

            InstanceVariables instanceVarObj = new InstanceVariables();
            instanceVarObj.mathsMarks = 90;
            instanceVarObj.engMarks = 70;
            instanceVarObj.scienceMarks = 85;
            Console.WriteLine($"""
            English Marks = {instanceVarObj.engMarks}
            Maths Marks = {instanceVarObj.mathsMarks}
            Science Marks = {instanceVarObj.mathsMarks}
            """);

            StaticVariables.EmpName = "Vinayak";
            StaticVariables.EmpSalary = 10000;
            Console.WriteLine($"""
            Employee name is {StaticVariables.EmpName};
            Employee Salary is {StaticVariables.EmpSalary};
            """);

            Console.WriteLine($"Constant variable {ConstantVariables.fileName}");

            ReadonlyVariables readonlyVarObj = new ReadonlyVariables();
            Console.WriteLine($"Constant variable {readonlyVarObj.variableType}");
        }
    }
}