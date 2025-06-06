#define shape
#define MYTEST
#undef shape
#pragma warning disable CS0219, 1030
using System.Reflection.Metadata;

string name = "vinayak";
int n = 23;

#region


#if shape
        Console.WriteLine("shape exists");
        Console.WriteLine("Exists..");
#else
                Console.WriteLine("shape does not exists");
#endif

                #endregion

#warning Repeated code

#if DEBUG
                Console.WriteLine("Debug");
#endif


#if !MYTEST
        Console.WriteLine("MYTEST is not defined");
#endif

// #error Deprecated code

#if DEBUG && !MYTEST
        Console.WriteLine("DEBUG is defined");
#elif !DEBUG && MYTEST
        Console.WriteLine("MYTEST is defined");
#else
                Console.WriteLine("DEBUG and MYTEST is not defiend");
#endif


