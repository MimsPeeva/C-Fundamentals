int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());
Console.WriteLine(SumN1N2(n1, n2) + SubtractN3(n3));
static int SumN1N2(int n1, int n2)
{
    return n1 + n2; 
}
static int SubtractN3(int n3)
{
    return -n3;
}