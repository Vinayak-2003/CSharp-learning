using System.Security.Cryptography.X509Certificates;
using Assembly1;

namespace Assembly1{

    // base class
    public class Assembly1BaseClass{
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public";

        // ---------- method within the same class ---------- //
        public void TestAccess(){
            // all accessible within the same class
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    // derived class
    public class Assembly1DerivedClass : Assembly1BaseClass{
        
        // ---------- method in the derived class ---------- //
        public void TestAccessDerived(){
            // not accessible in the derived class
            // Console.WriteLine(privateVariable);

            // accessible in the derived class
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    // other class
    public class OtherAssembl1Class{
        public void OtherTestAccess(){
            Assembly1BaseClass baseClassOtherObj = new Assembly1BaseClass();

                // not accessible in other class
                // Console.WriteLine(baseClassOtherObj.privateVariable);
                // Console.WriteLine(baseClassOtherObj.protectedVariable);

                // accessible in other class
                Console.WriteLine(baseClassOtherObj.internalVariable);
                Console.WriteLine(baseClassOtherObj.protectedInternalVariable);
                Console.WriteLine(baseClassOtherObj.publicVariable);
        }
    }

    // Main class
    class Program{
        static void Main(string[] args){
            // Assembly1BaseClass baseClassObj = new Assembly1BaseClass();
            // baseClassObj.TestAccess();

            // Assembly1DerivedClass derivedClassObj = new Assembly1DerivedClass();
            // derivedClassObj.TestAccessDerived();            // derived class
            // derivedClassObj.TestAccess();                   // base class

            OtherAssembl1Class OtherClassObj = new OtherAssembl1Class();
            OtherClassObj.OtherTestAccess();
        }
    }
}



// -------------------- Main class outside the namespace -------------------- //
// class Program{
//         static void Main(string[] args){
//             Assembly1.Assembly1BaseClass baseClassObj = new Assembly1.Assembly1BaseClass();
//             baseClassObj.TestAccess();
//         }
//     }