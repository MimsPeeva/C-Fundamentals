int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] maxLeft = new int[] { };
int left = 0;
int[] len = new int[arr.Length];
int high = 0;
for (int i = 0; i < arr.Length-1; i++)
{
    len[0] = 1;
    if (arr[i + 1] > arr[i]) { high = arr[i + 1];left = arr[i]; }
    len[i] = 1 + len[left]; 
    maxLeft[i] += high;
}

//for (int p = 0; p < arr.Length-1; p++)
//  {  int[] len = 1 + len[p+];}
Console.WriteLine(string.Join(" ", maxLeft));