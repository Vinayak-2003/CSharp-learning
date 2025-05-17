using System.IO.Pipelines;
using System.Reflection.PortableExecutable;

namespace TypeCasting{

    public class StringToInt{
        public static void StringToIntParse(string input){
            try{
                int result = Int32.Parse(input);
                Console.WriteLine(result);
            }
            catch (FormatException){
                Console.WriteLine($"Unable to parse {input}");
            }
        }

        public static void StringToIntGetParse(){
            const string inputString = "abc";
            if (Int32.TryParse(inputString, out int numVal)){
                Console.WriteLine(numVal);
            }
            else{
                Console.WriteLine($"Int32.TryParse could not parse {inputString} to an int");
            }
        }

        public static void CheckHexVal(string inputHex){
            string numericString = String.Empty;
            foreach (var c in inputHex){
                if ((c>='0' && c<='9') || (char.ToUpperInvariant(c) >= 'A' && char.ToUpperInvariant(c) <= 'F') || c == ' '){
                    numericString = string.Concat(numericString, c.ToString());
                }
                else{
                    break;
                }
            }
            if (int.TryParse(numericString, System.Globalization.NumberStyles.HexNumber, null, out int i)){
                Console.WriteLine($"'{inputHex}' --> '{numericString}' --> '{i}'");
            }
        }
    }

    class TypeCastingImplementation{
        public static void BasicTypeCasting(){
            int i = 23;
            Console.WriteLine(i);

            long j = i;
            Console.WriteLine(j);

            char ch = (char)i;
            Console.WriteLine(ch);

            string st = i.ToString();
            Console.WriteLine(st);

            if (i is int s){
                Console.WriteLine(s+4);
            }

            // implicit conversion
            int num = 478374844;
            long longNum = num;
            Console.WriteLine(longNum);

            // explicit conversion
            double d = 1234.56;
            int n;

            n = (int)d;
            Console.WriteLine(n);

            // convert byte array to int
            byte[] bytes = [1,0,4,25];
            if (BitConverter.IsLittleEndian){
                Array.Reverse(bytes);
                foreach (var b in bytes){
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }

            int byteInt = BitConverter.ToInt32(bytes, 0);
            Console.WriteLine($"After converting from bytes to int: {byteInt}");
        }
    }

    class Program{
        static void Main(string[] args){
            // TypeCastingImplementation.BasicTypeCasting();
            StringToInt.StringToIntParse(String.Empty);
            StringToInt.StringToIntParse("12233");
            StringToInt.StringToIntParse("-12233");
            StringToInt.StringToIntParse("-12 233");
            StringToInt.StringToIntGetParse();
            StringToInt.CheckHexVal("  10FFxx");
        }
    }
}