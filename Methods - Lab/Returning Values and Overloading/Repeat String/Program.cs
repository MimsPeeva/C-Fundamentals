string input = Console.ReadLine();
int times = int.Parse(Console.ReadLine());
string output = Output(input, times) ;
Console.WriteLine(output) ;
static string Output(string input, int times)
{
    string result = "";
    for (int i = 0; i < times; i++)
	{
		result+=input;
	}
	return result;
}
