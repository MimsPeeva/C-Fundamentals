int energy = int.Parse(Console.ReadLine());
string input;
int count = 0;
while ((input = Console.ReadLine()) != "End of battle")
{
    int distance = int.Parse(input);
    if (energy < distance)
    {
        Console.WriteLine($"Not enough energy! Game ends with " + $"{count} won battles and {energy} energy");
        return;
    }
        energy -= distance;
        count++;       
    if (count % 3 == 0)
    {
        energy += count;
    }
}
Console.WriteLine($"Won battles: {count}. Energy left: {energy}"); 

