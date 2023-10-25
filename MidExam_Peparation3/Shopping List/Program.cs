List<string>list = Console.ReadLine()
    .Split('!')
    .ToList();
string input;
while ((input = Console.ReadLine()) != "Go Shopping!")
{
    string[] lines = input.Split();
    string command = lines[0];
    string product = lines[1];
    if (command == "Urgent")
    {
        bool isExist = list.Contains(product);
        if (isExist)
        {
            continue;
        }
        else
        {
            list[0] = product;
            list.Insert(0,product);
        }
    }
    else if (command == "Unnecessary")
    {
        bool isExist = list.Contains(product);
        if (isExist)
        {
            list.Remove(product);
        }
        else { continue; }
    }
    else if (command == "Correct")
    {
        string newItem = lines[2];
        bool isExist = list.Contains(product);
        if (isExist)
        {
            int index = list.IndexOf(product);
            list[index] = newItem;
        }
        else { continue; }
    }
    else if (command == "Rearrange")
    {
        bool isExist = list.Contains(product);
        if (isExist)
        {
            list.Remove(product);
            list.Add(product);
        }
        else { continue; }
    }
}
Console.WriteLine(string.Join(", ", list));
