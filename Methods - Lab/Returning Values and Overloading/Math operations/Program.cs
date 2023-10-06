double n1 = double.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double result = Calculate( n1,  symbol, n2);
Console.WriteLine(result);
static double Calculate(double n1, char symbol, double n2)
{
    double result = 0;
    switch (symbol)
    {
        case '+': result = n1 + n2; break;
        case '-': result = n1 - n2; break;
        case '/': result = n1 / n2; break;
        case '*': result = n1 * n2; break;
    }
    return result;
}
