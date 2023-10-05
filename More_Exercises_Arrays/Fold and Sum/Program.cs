int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int fold = arr.Length / 4;
int[] resultSum = new int[arr.Length/2];
for (int i = 0; i < fold; i++)
{
    resultSum[i] = arr[fold + i] + arr[fold-(1+i)];
    resultSum[i + fold] = arr[i + 2*fold] + arr[arr.Length-i-1];
}

    
  

Console.WriteLine(String.Join(' ', resultSum));
