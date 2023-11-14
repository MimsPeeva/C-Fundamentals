int n = int.Parse(Console.ReadLine());
Dictionary<string, List<string>> Synonyms = new Dictionary<string, List<string>>();
for (int i = 0; i < n; i++)
{
      string key = Console.ReadLine();
    string value = Console.ReadLine();
if (!Synonyms.ContainsKey(key))
{
    Synonyms.Add(key, new List<string>());
}
List<string> synonyms = Synonyms[key];
    synonyms.Add(value);
}
foreach (var item in Synonyms)
{
    Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
}