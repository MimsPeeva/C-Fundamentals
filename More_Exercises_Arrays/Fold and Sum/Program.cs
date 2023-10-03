int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int firstLineSum = 0;
for (int i = 0; i < arr.Length; i++)
{
   int middle = arr.Length / 2;
    for (int j = 0; j < middle; j++)
    {
        for (int q = 0; q < middle/2; q++)
        {
            firstLineSum += arr[j];
            firstLineSum+=arr[j+1];
        }
      
    }
  
}
Console.WriteLine(firstLineSum);