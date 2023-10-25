int[] integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
string input;
int count = 0;
while ((input = Console.ReadLine())!="End")
{
    int index = int.Parse(input);
    if (index < 0 || index >= integers.Length)
    { 
        continue;
    }
    int targetValue = integers[index];
    if (integers[index] == -1)
    { 
        continue; 
    }
        integers[index] = -1;
        count++;
    for (int i = 0; i < integers.Length; i++)
    {
        if (integers[i] == -1)
        {
            continue;
        }
        else if (targetValue < integers[i])
        {
            integers[i] -= targetValue;
        }
        else if (targetValue >= integers[i])
        { 
            integers[i] += targetValue; 
        }
    }
}
Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", integers)}");
