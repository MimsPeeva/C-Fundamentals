List<int> integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] lineTokens = input.Split(' ').ToArray();
    string command = lineTokens[0];
    if (command == "Delete")
    {
        int number = int.Parse(lineTokens[1]);
        for (int i = 0; i < integers.Count; i++)
        {
            if (integers[i] == number)
            { integers.Remove(integers[i]);
                //i--;
            }
        }
    }
    else if(command=="Insert")
    {
        int n1 = int.Parse(lineTokens[1]);
        int n2 = int.Parse(lineTokens[2]);
        integers.Insert(n2,n1);
    }
}
Console.WriteLine(string.Join(" ", integers));
