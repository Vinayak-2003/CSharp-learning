int x = 3, y = 6;
Console.WriteLine("Addition: " + (x+y));


// -------- ternary operator --------- //
int num = 11;
int ans = (num % 2) == 0 ? num / 2 : (num + 1)/2;
Console.WriteLine(ans);


// -------- Null coalescing operator --------- //
string? name = null;
string result = name ?? "Kanchan";
Console.WriteLine(result);

int? n = null;
int number = n ?? 11;
Console.WriteLine(number);