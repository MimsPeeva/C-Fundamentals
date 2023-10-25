List<long> list = Console.ReadLine()
    .Split()
    .Select(long.Parse)
    .ToList();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] elements = input.Split(' ').ToArray();
    string command = elements[0];
    
    if (command == "swap")
    {
        int index1 = int.Parse(elements[1]);
        int index2 = int.Parse(elements[2]);
        long swap = list[index1];
        list[index1] = list[index2];
        list[index2] = swap;
    }
    else if (command == "multiply")
    {
        int index1 = int.Parse(elements[1]);
        int index2 = int.Parse(elements[2]);
        list[index1] = list[index1] * list[index2];
    }
    else if (command == "decrease")
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] -= 1;
        }
    }
}
Console.WriteLine(string.Join(", ", list));
