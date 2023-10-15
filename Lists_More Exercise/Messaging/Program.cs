using System.Diagnostics.CodeAnalysis;

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List <char> input = new List<char>();
input.AddRange(Console.ReadLine());
string word = "";
for (int i = 0; i < list.Count; i++)
{
    int sum = 0;
    while (list[i] != 0)
    {
        sum += list[i] % 10;
        list[i] = list[i] / 10;
    }
    int times = sum / input.Count;
    sum = sum - times * input.Count;
    Console.Write(input[sum]);
    input.RemoveAt(sum);
}
/*
 9992 562 8933
This is some message for you
 */