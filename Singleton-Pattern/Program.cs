using System.Data.Common;
using System.Diagnostics.Metrics;

namespace SingletonPatternImplementation
{
    public sealed class Singleton
    {
        // this variable will be incremented by 1 each time the object of a class is created
        private static int counter = 0;

        // this variable will store the Singleton Instance 
        private static Singleton? Instance = null;

        // this will return the singleton instance
        public static Singleton GetInstance()
        {
            // this is not thread safe
            if (Instance == null)
            {
                Instance = new Singleton();
            }

            return Instance;
        }

        // private constructor means we cannot create an instance of this class
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value " + counter.ToString());
        }

        public void DisplayDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        public static void Main()
        {
            Singleton singleton1 = Singleton.GetInstance();
            singleton1.DisplayDetails("singleton pattern 1 ....");

            Singleton singleton2 = Singleton.GetInstance();
            singleton2.DisplayDetails("Singleton pattern 2 ....");
        }
    }
}