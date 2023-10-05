int wantedFnumber = int.Parse(Console.ReadLine());
long sum = 0;
long[] currentN = new long[wantedFnumber];
for (int i = 0; i < wantedFnumber; i++)
{
    currentN[0] = 1; currentN[1] = 1;
    if (i == 0 || i == 1)
    {
        if (i == 0) { sum = 1; continue; }
        else if (i == 1) { sum += 1; continue; }
    }
    for (int j = 2; j < currentN.Length; j++)
    {
        currentN[j] = currentN[j - 1] + currentN[j - 2];
        sum = currentN[j];
    }
   

}
Console.WriteLine(sum);
/*int fibonachiNumber = int.Parse(Console.ReadLine());//100 in judje
            
            int[] startArr = new int[] { 1, 1 };
            

            for (int i = 0; i < fibonachiNumber; i++)
            {
                int[] sequenceOfFibonachi = new int[startArr.Length + 1];
                sequenceOfFibonachi[0] = 1;
                sequenceOfFibonachi[1] = 1;

                for (int j = 2; j < sequenceOfFibonachi.Length; j++)
                {
                    sequenceOfFibonachi[j] = startArr[j - 2] + startArr[j - 1];
                }

                startArr = sequenceOfFibonachi.ToArray();
            }
            
            Console.WriteLine($"{startArr[fibonachiNumber - 1]}");
 */