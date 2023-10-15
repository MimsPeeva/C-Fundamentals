List<int> list1 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> list2 = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> result = new List<int>();
for (int i = 0; i < list1.Count; i++)
{
    for (int j = list2.Count -1; j >= 0; j--)
    {
        result.Add(list1[i]);
        list1.RemoveAt(i);
        i = -1;
        result.Add(list2[j]);
        list2.RemoveAt(j);
        j = -1;
    }  
}

int start = 0;
int end = 0;
if (list1.Count > 0)
{
    start =list1[0];
    end = list1[1];
    
}
else
{
    start = list2[0];
    end = list2[1];
}
int min = Math.Min(start,end);
int max = Math.Max(start,end);
List<int> output = new List<int>();
for (int i = 0; i < result.Count; i++)
{
    if (result[i] > min && result[i] < max)
    {
        output.Add(result[i]);
    }
}
output.Sort();
Console.WriteLine(string.Join(" ",output));
/*
1 5 23 64 2 3 34 54 12
43 23 12 31 54 51 92
*/