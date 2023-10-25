using System.Security.Cryptography;

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string input;
while (true)
{
    input = Console.ReadLine();
    if (input == "Finish")
    { break; }
    string[] lines = input.Split();
    string command = lines[0];
    int value = int.Parse(lines[1]);
    if (command == "Add")
    {
        list.Add(value);
    }
    else if (command == "Remove")
    {
        if (list.Contains(value))
        { list.Remove(value); }
    }
    else if (command == "Replace")
    {
        int replaceEl = int.Parse(lines[2]);
        bool isExist = list.Contains(value);
        if (isExist)
        {
            int index = list.IndexOf(value);
            list[index] = replaceEl;
        }
        else { continue; }
    }
    else if (command == "Collapse")
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < value)
            {
                list.RemoveAt(i);
                i = -1;
            }
        }
    }
}
Console.WriteLine(string.Join(" ", list));
/*
5 9 70 -56 9 9
Replace 9 10
Remove 9
Finish
 */