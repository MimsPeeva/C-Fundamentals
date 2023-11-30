using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @"\#{1}[A-z]{3,}\#{2,}[A-z]{3,}\#{1}|\@{1}[A-z]{3,}\@{2,}[A-z]{3,}\@{1}";
List<string> validPairs = new List<string>();
List<string> mirroredPairs = new List<string>();
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
if (matches.Count == 0)
{ Console.WriteLine("No word pairs found!"); }
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");
}
string[] words = 
/*
@mix#tix3dj#poOl##loOp#wl@@bong&song%4very$long@thong#Part##traP##@@leveL@@Level@##car#rac##tu@pack@@ckap@#rr#sAw##wAs#r#@w1r	
*/