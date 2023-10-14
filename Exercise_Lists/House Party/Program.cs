int numberCommands = int.Parse(Console.ReadLine());
List<string> guestList = new List<string>();
for (int i = 0; i < numberCommands; i++)
{
    string[] command = Console.ReadLine().Split();
    string guest = command[0];
    if (command[2] == "going!")
    {
        if (guestList.Exists(e => e == guest))//guestList.Contains(guest)
        { Console.WriteLine($"{guest} is already in the list!"); }
        else
        { guestList.Add(guest); }
    }
    else if (command[2] == "not")
    {
        if (guestList.Contains(guest))
        { guestList.Remove(guest); }
        else
        { Console.WriteLine($"{guest} is not in the list!"); }
    }
}
foreach (string guest in guestList)
{
Console.WriteLine(guest);
}
