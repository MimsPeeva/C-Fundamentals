char startChar = char.Parse(Console.ReadLine());
char endChar = char.Parse(Console.ReadLine());
Console.WriteLine(ChInRange(startChar, endChar));
static string ChInRange(char start, char end)
{
    string output = string.Empty;
    int startCh = Math.Min(start,end);
    int endCh = Math.Max(start,end);
    for (int i = startCh+1; i < endCh; i++)
	{
       
        output += (char)i + " ";
	}
	return output;
}