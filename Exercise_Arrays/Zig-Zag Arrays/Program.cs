﻿var n = int.Parse(Console.ReadLine());
int [] arr1 = new int[n];
int[] arr2 = new int[n];
for (int i = 0; i < n; i++)
{
    
    var input = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();
    if (i % 2 == 0)
            {
        arr1[i] = input[0];
        arr2[i] = input[1];
            }
            else
    {
        arr1[i] = input[1];
        arr2[i] = input[0];
    
    }
   
}
var firstArray = string.Join(' ',arr1);
var secondArray = string.Join(' ', arr2);

Console.WriteLine(firstArray);
Console.WriteLine(secondArray);