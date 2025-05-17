using System.Diagnostics;

namespace ExceptionHandlingNamespace{
    public class ExceptionHandling{
        public static double SafeDivision(double x, double y){
            if (y == 0){
                throw new DivideByZeroException();
            }
            return x/y;
        }
    }

    // custom excpetion
    class CustomException : Exception{
        public CustomException(string message){

        }

        public static void TestThrow(){
            throw new CustomException("Custom exception ...");
        }
    }

    // test finally block
    class FinallyImplementation{
        public static void TestFInally(){
            FileStream? file = null;
            FileInfo fileInfo = new System.IO.FileInfo("./file.txt");

            try{
                file = fileInfo.OpenWrite();
                file.WriteByte(6);
                Console.WriteLine("In try block ..... successfully written");
            }
            finally {
                file?.Close();
                Console.WriteLine("In finally block .... Closing the file");
            }

            try{
                file.WriteByte(6);
                Console.WriteLine("In try block ..... successfully written");
            }
            catch (IOException){
                Console.WriteLine("In catch block .... OpenWrite() failed");
            }
            catch (Exception e){
                throw new Exception($"Unexpected error occurred {e}");
            }
            finally {
                Console.WriteLine("Finally block executed ...");
            }
        }

        
        
    }

    // method causes an exception
    class IndexOutOfRange{
        public static int GetValueFromArray(int[] array, int idx){
            try{
                return array[idx];
            }
            catch (IndexOutOfRangeException e){
                throw new ArgumentOutOfRangeException("index out of range", e);
            }
        }
    }

    public class Program{
        public static void Main(){
            double a = 88, b = 0;
            int[] arr = [1,2,3,4,5,6,7];
            double result;

            try{
                result = ExceptionHandling.SafeDivision(a, b);
                Console.WriteLine($"Dividing {a} by {b} gives result {result}");
            }
            catch{
                Console.WriteLine("Why are you dividing by zero?");
            }

            // CustomException.TestThrow();
            FinallyImplementation.TestFInally();

            IndexOutOfRange.GetValueFromArray(arr,1);
        }
    }
}