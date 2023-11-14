using System.Text;

string[] input = Console.ReadLine().Split();
string result = string.Empty;
foreach (var item in input)
{
    int repeat = item.Length;
    for (int i = 0; i < repeat; i++)
    {
        result += item;
    }
}
Console.WriteLine(result);
//second variant
/*
tring[] input1 = Console.ReadLine().Split();
StringBuilder result1 = new StringBuilder();
foreach (var item in input1)
{
    int repeat = item.Length;
    for (int i = 0; i < repeat; i++)
    {
       result1.Append(item);
    }
}
Console.WriteLine(result1);
*/