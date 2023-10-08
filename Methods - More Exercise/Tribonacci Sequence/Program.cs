uint num = uint.Parse(Console.ReadLine());
TribonacciSequence(num);
static void TribonacciSequence(uint num)
{
	uint firstIndex = 1;
	uint secondIndex = 1;
	uint thirdIndex = 2;
    if (num == 1) { Console.WriteLine(firstIndex); return; }
	if (num == 2) { Console.WriteLine($"{firstIndex} {secondIndex}"); return; }
	if (num == 3)  { Console.Write($"{firstIndex} {secondIndex} {thirdIndex} "); }
	if(num>3)
	{
        Console.Write($"{firstIndex} {secondIndex} {thirdIndex} ");
		for (int i = 3; i < num; i++)
		{

			uint nextIndex = firstIndex + secondIndex + thirdIndex;
			Console.Write(nextIndex + " ");
			firstIndex = secondIndex;
			secondIndex = thirdIndex;
			thirdIndex = nextIndex;
		}
	}
}