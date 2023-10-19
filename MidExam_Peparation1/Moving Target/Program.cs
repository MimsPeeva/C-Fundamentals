List<int> targets = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string input;
while ((input = Console.ReadLine())!="End")
{
    string[] command = input.Split(' ');
    switch (command[0])
    {
        case "Shoot":
            int index = int.Parse(command[1]);
            int power = int.Parse(command[2]);
            if (index >= 0 && index < targets.Count)
            {
                targets[index] -= power;
                if (targets[index] <= 0)
                { targets.RemoveAt(index); }
            }
            continue;
        case "Add": 
            int index1 = int.Parse(command[1]);
            int value = int.Parse(command[2]);
            if (index1 >= 0 && index1 < input.Length)
            {
                targets.Insert(index1, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
            continue;
        case "Strike":
            int index2 = int.Parse(command[1]);
            int radius = int.Parse(command[2]);

            if (IsValid(index2, targets)&&IsValid(index2-radius, targets)&&IsValid(index2+radius, targets))
            {
                targets.RemoveRange(index2-radius, 2*radius+1);
            }
            else
            { Console.WriteLine("Strike missed!"); }
            continue;
    }
}
Console.WriteLine(string.Join("|", targets));

static bool IsValid(int index, List<int>targets)
{
    return index>=0 && index < targets.Count;
}
