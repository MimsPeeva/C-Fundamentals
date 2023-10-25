using System.Globalization;

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
int averageSum = list.Sum() / list.Count;
List<int> output = new List<int>();
for (int i = 0; i < list.Count; i++)
{
    if (list[i] > averageSum)
    {
        output.Add(list[i]);
    }
}
output.Sort();
if (output.Count == 0)
{
    Console.WriteLine("No");
}
else if (output.Count < 5)
{
    output.Reverse();
    Console.WriteLine(string.Join(" ", output));

}
else
{
    for (int i = 0; i < output.Count; i++)
    {
        while (output.Count != 5)
        {
            output.RemoveAt(i);
        }
    }
    output.Reverse();
    Console.WriteLine(string.Join(" ", output));
}
