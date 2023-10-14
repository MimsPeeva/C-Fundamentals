List<int> integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string input =default;
while ((input=Console.ReadLine()) != "end")
{
    string[] lineTokens = input.Split().ToArray();
    string command = lineTokens[0];
    int number = int.Parse(lineTokens[1]);
    switch (command)
    {
        case "Add":integers.Add(number); break;
        case "Remove": integers.Remove(number); break;
        case "RemoveAt": integers.RemoveAt(number); break;
        case "Insert":
            int indexToInsert = int.Parse(lineTokens[2]);
           integers.Insert(indexToInsert,number); break;
    }
}
Console.WriteLine(string.Join(" ", integers)); 
