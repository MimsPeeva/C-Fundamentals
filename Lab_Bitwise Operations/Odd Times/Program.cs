List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
int result = 0;
for (int i = 0; i < list.Count; i++)
{
    result ^=  list[i];
}
Console.WriteLine(result);