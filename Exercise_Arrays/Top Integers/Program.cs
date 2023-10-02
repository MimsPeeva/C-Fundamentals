int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
for (int i = 0; i < arr.Length; i++)
{
    bool isTrue = true;
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] <= arr[j])
        {
            isTrue = false;
        }
    }
    if(isTrue)
    Console.Write(arr[i] + " ");
}

