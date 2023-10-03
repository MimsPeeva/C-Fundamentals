int lines = int.Parse(Console.ReadLine());
long[] row = new long[lines];
long[] currentRow = new long[lines];
row[0] = 1;
Console.WriteLine(row[0]);
for (int i = 1; i < lines; i++)
{
	for (int j = 0; j <= i; j++)
	{
		if (j == 0) { currentRow[j] = 0 + row[j]; }
		else { currentRow[j] = row[j] + row[j - 1]; }
		Console.Write($"{currentRow[j]+ " "}");
	}
    for (int q = 0; q < lines; q++)
    {
        row[q] = currentRow[q];
    }
    Console.WriteLine();
   
}
