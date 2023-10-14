List<int> line1 = ReadList();
List <int> line2 = ReadList();
List <int> result = new List<int>();
int maxLength = Math.Max(line1.Count,line2.Count);
for (int i = 0; i < maxLength; i++)
{
    if (i <line1.Count)
    {
        result.Add(line1[i]);
    }
    if (i < line2.Count)
    {
        result.Add(line2[i]);
    }
}
Console.WriteLine(string.Join(" ", result));
 static List<int> ReadList()
{
    return Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
}
