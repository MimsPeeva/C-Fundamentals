﻿int n = int.Parse(Console.ReadLine());
IsTopNumber(n);
static void IsTopNumber(int n)
{
	bool isOdd = false;
	bool isDivisible = false;
	int sumDigits = 0;
	int currentDigit = 0;
	for (int i = 1; i <= n; i++)
	{
		currentDigit = i;
		while (currentDigit > 0)
		{
            if ((currentDigit % 10)% 2 == 1){ isOdd = true; }
            sumDigits += currentDigit % 10;
			currentDigit/=10;
        }
        if (sumDigits % 8 == 0 )
		
		{
			isDivisible = true;
		}
		if (isDivisible==true && isOdd==true)
		{ Console.WriteLine(i); }
		sumDigits = 0;
 		isOdd = false;
		isDivisible = false;
	}
}