string input = Console.ReadLine();
Console.WriteLine(MiddleCh(input));
static string MiddleCh(string input)
{
   string ch =" ";
    char output;
    if (input.Length % 2 == 1)
    {
        ch = input[input.Length / 2].ToString();
    }
    
    else
    {
        ch = input[input.Length / 2-1].ToString() + input[input.Length/2].ToString();
    }
    return ch;
}