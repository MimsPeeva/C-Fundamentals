using System.ComponentModel.DataAnnotations;

int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int maxLength = 0;
int lastIndex = -1;
int[] len = new int[arr.Length];
int[] prev = new int[arr.Length];
int high = 0;
for (int i = 0; i < arr.Length; i++)
{
    len[i] = 1;
    prev[i] = -1;

    for (int j = 0; j < i; j++)
    {
        if (arr[i] > arr[j] && len[j] > len[i])
        {
            len[i] = 1 + len[j];
            prev[i] = j;
        }
    }

    if (len[i] > maxLength)
    {
        maxLength = len[i];
        lastIndex = i;
    }
}
int[] lis = new int[maxLength];
for (int i = 0; i < maxLength; i++)
{
    lis[i] = arr[lastIndex];
    lastIndex = prev[lastIndex];
}
Array.Reverse(lis);
Console.WriteLine(string.Join(" ", lis));