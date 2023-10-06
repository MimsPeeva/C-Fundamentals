int n = Math.Abs(int.Parse(Console.ReadLine()));
 int result = GetMultipleOfEvenAndOdds(n);
Console.WriteLine(result);

static int GetMultipleOfEvenAndOdds(int n)
{
    int sumEvens = GetSumOfEvenDigits(n);
    int sumOdds = GetSumOfOddDigits(n);
    return sumEvens * sumOdds;
}
static int GetSumOfEvenDigits(int n)
{
    int sumEven = 0;
    while (n > 0)
    {
        int nextN = n % 10;
 
        if (nextN % 2 == 0) { sumEven += nextN; }
        n /= 10;
    }
    return sumEven;
}
static int GetSumOfOddDigits(int n)
{
    int sumOdd = 0;
    while (n >0)
    {
        int nextN = n % 10;
     
        if (nextN % 2 == 1) { sumOdd += nextN; }
        n /= 10;
    }
    return sumOdd;
}