string input = Console.ReadLine();
Dictionary<char,int> counts = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char ch = input[i];
    if (ch == ' ') { continue; }
    if (!counts.ContainsKey(ch))
    {
       counts.Add(ch, 1);
    }
    else
    counts[ch]+=1;

}


foreach (KeyValuePair<char,int> item in counts)
{
    char ch = item.Key;
    int count = item.Value;
    Console.WriteLine($"{ch} -> {count}");
}