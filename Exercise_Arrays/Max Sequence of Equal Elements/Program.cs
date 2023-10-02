int[] arr=Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int output=0;
int counter = 1;
int maxCounter = 0;
for (int i = 0; i < arr.Length-1; i++)
{
    if (arr[i] == arr[i + 1])
    {
        counter++;
    }
    else
    {
        counter = 1;
    }
        if (counter > maxCounter)
        {
            maxCounter = counter;
            output = arr[i];
        }
   
}
for (int j = 0; j < maxCounter; j++)
{
    Console.Write($"{output + " "}");
}