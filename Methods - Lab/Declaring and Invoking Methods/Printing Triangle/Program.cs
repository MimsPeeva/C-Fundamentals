int input = int.Parse(Console.ReadLine());
for (int i = 1; i <= input; i++)
{
	printTriangle(1,i);
}
for (int i = input - 1;  i>= 1; i--)
{
	printTriangle(1,i);
}
static void printTriangle(int start, int end)
{
	for (int i = start; i <= end; i++)
	{
		Console.Write(i + " ");
    }
	Console.WriteLine();
}