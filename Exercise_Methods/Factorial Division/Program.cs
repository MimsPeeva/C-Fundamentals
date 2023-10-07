int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine($"{(Divide(Factorial1(n1), Factorial2(n2))):f2}");
static long Factorial1(int n1)
{
	long fact1 = 1;
	for (long i = 1; i <= n1; i++)
	{
		fact1 *= i;
	}
    return fact1;
}
static long Factorial2(int n2)
{
    long fact2 = 1;
    for (long i = 1; i <= n2; i++)
    {
        fact2 *= i;
    }
    return fact2;
}
static double Divide(long Factorial1,long Factorial2)
{ 
    double result = (Factorial1*1.0 / Factorial2);
    return result;
}