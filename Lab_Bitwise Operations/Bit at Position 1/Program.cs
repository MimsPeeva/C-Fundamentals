int n = int.Parse(Console.ReadLine());
int shiftedN = n >> 1;
int result = shiftedN & 1;
Console.WriteLine(result);