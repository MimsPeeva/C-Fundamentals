string[] arr = Console.ReadLine()
    .Split()
    .ToArray();
for (int i = 0; i < arr.Length/2; i++)
{
    string firstEl = arr[i];
    string lastEl = arr[arr.Length - 1 - i];
    arr[i] = lastEl;
    arr[arr.Length - 1 - i] = firstEl;
}
Console.WriteLine(string.Join(" ", arr));
