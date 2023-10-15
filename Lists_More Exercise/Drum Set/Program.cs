double savings = double.Parse(Console.ReadLine());
List<int> drumSet = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string input = "";
List<int> price = new List<int>();
price.AddRange(drumSet);
while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
{
    int hitPower = int.Parse(input);
    for (int i = 0; i < drumSet.Count; i++)
    {
        drumSet[i] -= hitPower;
        if (drumSet[i] <= 0)
        { if (savings - price[i] * 3 >= 0)
            { 
                savings -= price[i] * 3;
                drumSet[i] = price[i];
            }
        }
    }
    for (int i = 0; i < drumSet.Count; i++)
    {
        if (drumSet[i] <= 0)
        {
            drumSet.Remove(drumSet[i]);
            price.Remove(price[i]);
        }
    }
}
Console.WriteLine(string.Join(" ", drumSet));
Console.WriteLine($"Gabsy has {savings:f2}lv.");
