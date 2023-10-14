List<int> integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> result = new List<int>();
for (int i = 0; i < integers.Count; i++)
{
    if (integers[i] < 0)
    {
        integers.RemoveAt(i);
        i--;
    }
    else
    {
        result.Add(integers[i]);
    }
}
if (result.Count == 0) { Console.WriteLine("empty"); }
result.Reverse();
Console.WriteLine(string.Join(" ", result));