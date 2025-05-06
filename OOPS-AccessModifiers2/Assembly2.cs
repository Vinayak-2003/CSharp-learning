using Assembly1;

namespace Assembly2{

    public class Assembly2BaseClass : Assembly1BaseClass{

        public void TestAccessAssembly2DerivedClass(){

            // not accessible in derived class of another assembly
            // Console.WriteLine(privateVariable);
            // Console.WriteLine(internalVariable);
            
            // accessible in derived class of another assembly
            Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Aseembly2OtherClass{
        public void TestAccessAssembly2Other(){
            Assembly1BaseClass baseClassAssembly2Obj = new Assembly1BaseClass();

            // not accessible in other class in assembly 2
            // Console.WriteLine(baseClassAssembly2Obj.privateVariable);
            // Console.WriteLine(baseClassAssembly2Obj.protectedVariable);
            // Console.WriteLine(baseClassAssembly2Obj.internalVariable);
            // Console.WriteLine(baseClassAssembly2Obj.protectedInternalVariable);

            // accessible in other class in assembly 2
            Console.WriteLine(baseClassAssembly2Obj.publicVariable);
        }
    }

    class Program{
        static void Main(string[] args){
            // Assembly2BaseClass baseClassAssembly2Obj = new Assembly2BaseClass();
            // baseClassAssembly2Obj.TestAccessAssembly2DerivedClass();
            // baseClassAssembly2Obj.TestAccess();

            Aseembly2OtherClass otherClassAssembly2Obj = new Aseembly2OtherClass();
            otherClassAssembly2Obj.TestAccessAssembly2Other();
        }
    }
}