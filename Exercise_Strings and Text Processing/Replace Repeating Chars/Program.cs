using System.Text;

string input = Console.ReadLine();
StringBuilder newStr = new StringBuilder();
newStr.Append(input[0]);
for (int i = 1; i < input.Length; i++)
{
    if (input[i] != input[i - 1])
    {
        newStr.Append(input[i]);
    }
}
Console.WriteLine(newStr);