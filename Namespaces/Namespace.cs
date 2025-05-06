using System.Data;
using System.Net;
using Microsoft.VisualBasic;

namespace OuterNamespace{

    class InnerNamespaceClass1{
        public static void DisplayLowerCase(){
            Console.WriteLine("hello from the innernamespaceclass1");
        }
    }

    // class InnerNamespaceClass1{
    //     public static void display(){
    //         Console.WriteLine("HELLO FROM THE INNERNAMESPACECLASS2");
    //     }
    // }
}

class OuterClass{
    static void Main(String[] args){
        OuterNamespace.InnerNamespaceClass1.DisplayLowerCase();
    }
}