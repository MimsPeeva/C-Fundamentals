string[] words = Console.ReadLine()
    .Split()
    .ToArray();

Dictionary<string, int> OddOccurrences = new Dictionary<string, int>();
foreach (string word in words)
{
    if (OddOccurrences.ContainsKey(word.ToLower()))
    {
        OddOccurrences[word]++;
    }
    else
    {
        OddOccurrences.Add(word.ToLower(),1);
    }
}
foreach (var item in OddOccurrences)
{
    if (item.Value % 2 == 1)
    {
        Console.Write(item.Key + " ");
    }
}
