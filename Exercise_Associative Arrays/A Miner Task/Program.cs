string input;
    Dictionary<string, uint> dict = new Dictionary<string, uint>();
while ((input=Console.ReadLine())!="stop")
{
    if (!dict.ContainsKey(input))
    { dict.Add(input, 0); }
    uint n = uint.Parse(Console.ReadLine());
    dict[input] += n;
}
foreach (var item in dict)
{
Console.WriteLine($"{item.Key} -> {(item.Value)}");
}
/*
Gold
155
Silver
10
Copper
17
stop
*/