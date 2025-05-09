using System;

namespace ReferenceType{

    class StringType{
        string a = "hello";
        string b = "h";
        public StringType(){
            b += "ello";
            Console.WriteLine(a == b);                          // True
            Console.WriteLine(Object.ReferenceEquals(a,b));     // False
        }
    }
    class Program{
        static void Main(string[] args){
            StringType stringRefType = new StringType();
        }
    }
}