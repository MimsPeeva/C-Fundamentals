int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sumOdd = 0;
int sumEven = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int n = numbers[i];
    if (n % 2 == 0)
    { sumEven += n; }
    else { sumOdd += n; }
}
int difference = sumEven - sumOdd;
Console.WriteLine(difference);
