int n = int.Parse(Console.ReadLine());
int step = int.Parse(Console.ReadLine());
 int shiftedN = n >> step;
int result = shiftedN&1;
Console.WriteLine(result);