int number = int.Parse(Console.ReadLine());
int index = int.Parse(Console.ReadLine());
int mask = 1 << index;
mask = ~mask;
int result = number & mask;
Console.WriteLine(result);