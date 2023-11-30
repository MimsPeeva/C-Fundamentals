using System.Text.RegularExpressions;

string pattern = @"(\:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
string coolPattern = @"\d";
string input = Console.ReadLine();
ulong threshold = 1;
List<string>coolEmojies = new List<string>();
foreach (Match match in Regex.Matches(input, coolPattern))
{
   
        threshold *= ulong.Parse(match.Value);    
}
MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
        ulong sum = 0;
    string emojiStr = match.Groups["emoji"].Value;
    foreach (char character in emojiStr)
    {
        sum += character;
    }
    if (sum >= threshold)
    {
        coolEmojies.Add(match.Value); 
    }
}
Console.WriteLine($"Cool threshold: {threshold}");
Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
coolEmojies.ForEach(emoji=>Console.WriteLine(emoji));
/*
In the Sofia Zoo there are 311 animals in total! ::Smiley:: This includes 3 **Tigers**, 1 ::Elephant:, 12 **Monk3ys**, a **Gorilla::, 5 ::fox:es: and 21 different types of :Snak::Es::. ::Mooning:: **Shy**
*/