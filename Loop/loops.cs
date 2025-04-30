// --------------- for statement --------------- //
Console.WriteLine("for statement");
for(int i=0;i<5;++i){
    Console.Write(i + " ");
}
Console.WriteLine("");


// --------------- foreach statement --------------- //
Console.WriteLine("foreach statement");
List<int> fibNumber = new() {0,1,1,2,3,5,8,13};
foreach (int element in fibNumber){
    Console.Write(element + " ");
}
Console.WriteLine("");


// --------------- do statement --------------- //
Console.WriteLine("do statement");
int n = 110;
do{
    Console.Write(n + " ");
    n++;
}while(n < 115);
Console.WriteLine("");


// --------------- while statement --------------- //
Console.WriteLine("while statement");
int p = 1000;
while (p < 1010){
    Console.Write(p + " ");
    p++;
}
Console.WriteLine("");