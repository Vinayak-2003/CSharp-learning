// ------------ Value Data Types ------------ //
int? m = null;
Console.WriteLine(m);

int a = 5;
int b = a + 2;
Console.WriteLine(b);

char c = 'G';
Console.WriteLine(c);

long l = -5373527457;
Console.WriteLine(l);

ulong L = 7436728;
Console.WriteLine(L);

float f = 1.23456789123f;                                   // 4 bytes (6-9 digits)
double d = 1.23456789123;                                   // 8 bytes (15 - 17 digits)
decimal de = 1.234567891232345678912323456789123m;          // 16 bytes (28 - 29 digits)

Console.WriteLine(f);
Console.WriteLine(d);
Console.WriteLine(de);


// ------------ Reference Data Types ------------ //

string str = "My naMe is ";
str += "VinAyaK";
Console.WriteLine(str);
Console.WriteLine(str.GetType());

object obj;
obj = 546738;
Console.WriteLine(obj);
Console.WriteLine(obj.GetType());


// ------------ Pointer Data Types ------------ //

unsafe{
    int n = 10;
    int* p = &n;

    Console.WriteLine("Value: {0}", n);
    Console.WriteLine("Address: {0}", (int)p);
}


// ------------ Runtime Initialization for variables ------------ //
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);