string[] stringArray = Console.ReadLine()
    .Split('|', StringSplitOptions.RemoveEmptyEntries);
List<string> list = ExtractNumbers(stringArray);
Console.WriteLine(string.Join(" ",list));
static List <string> ExtractNumbers(string[] stringArray)
{
	List<string> result = new List<string>();
	for (int i = stringArray.Length-1; i >= 0; i--)
	{
		string sequence = stringArray[i];
		string[] arr = sequence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
		result.AddRange(arr);
	}
	return result;
}
