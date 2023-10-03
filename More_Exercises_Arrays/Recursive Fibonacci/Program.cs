int wantedFnumber = int.Parse(Console.ReadLine());
long sum = 0;
long[] currentN = new long[wantedFnumber];
for (int i = 0; i < wantedFnumber; i++)
{
    if (i == 0 || i == 1) { currentN[0] = 1; currentN[1] = 1; }
    else
    {
        currentN[i] = currentN[i - 1] + currentN[i - 2];
    }
    sum = currentN[i];
}
Console.WriteLine(sum);