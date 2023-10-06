string input = Console.ReadLine();
int count = CountVowels(input);
Console.WriteLine(count);
static int CountVowels(string input)
{
	int count = 0;
	for (int i = 0; i < input.Length; i++)
	{
		if (isVowel (input[i]))
		{ count++; }
	}
	return count;
}
static bool isVowel(char input)
{
	return (input == 'a' || input == 'e' || input == 'o' || input == 'u' || input == 'i' || input == 'y'
				|| input == 'A' || input == 'E' || input == 'O' || input == 'U' || input == 'I' || input == 'Y');
}