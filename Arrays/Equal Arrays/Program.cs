﻿int[] arr1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] arr2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int sum = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] != arr2[i]) { Console.WriteLine($"Arrays are not identical. Found difference at {i} index"); return; }
    else if (arr1[i] == arr2[i])
    {
        int el = arr1[i];
        sum += el;
      
    }
}
Console.WriteLine($"Arrays are identical. Sum: {sum}");


