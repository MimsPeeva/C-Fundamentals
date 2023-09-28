int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int n = numbers[i];
    if (n % 2 == 0)
    { sum += n; }
}
Console.WriteLine(sum);