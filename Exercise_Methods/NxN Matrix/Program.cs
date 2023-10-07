int number = int.Parse(Console.ReadLine());
NxN(number);
static void NxN(int n)
{
	for (int i = 0; i < n; i++)
	{
		Console.Write(n + " ");
	
		for (int j = 1; j < n; j++)
		{
			Console.Write(n + " ");
		}
        Console.WriteLine();
    }
}