int[] array = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

bool isTrue = false;

for (int i = 0; i < array.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;

    for (int j = i - 1; j >= 0; j--)
    {
        if (j < 0)
        {
            break;
        }

        leftSum += array[j];
    }

    for (int k = i + 1; k < array.Count(); k++)
    {
        if (k > array.Length - 1)
        {
            break;
        }

        rightSum += array[k];
    }

    if (leftSum == rightSum)
    {
        isTrue = true;
        Console.Write(i);
    }

}

if (!isTrue)
{
    Console.WriteLine("no");
}
        