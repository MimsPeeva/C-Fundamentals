List<int> arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
double leftSum = 0;
double rightSum = 0;
int middleIndex = arr.Count / 2 + 1;
for (int i = 0; i < middleIndex-1; i++)
{
    if (arr[i] == 0)
    {
        leftSum *= 0.8;
    }
    else { leftSum += arr[i]; }
}
for (int i = arr.Count-1; i >= middleIndex; i--)
{
    if (arr[i] == 0)
    {
        rightSum *= 0.8;
    }
    else { rightSum += arr[i]; }
}
if (leftSum < rightSum)
{
    double time = leftSum;
    Console.WriteLine($"The winner is left with total time: {time:#.#}");
}
else
{
    double time = rightSum;
    Console.WriteLine($"The winner is right with total time: {time:#.#}"); }
