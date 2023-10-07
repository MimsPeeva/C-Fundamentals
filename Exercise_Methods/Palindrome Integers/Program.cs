string input = Console.ReadLine();
IsPalindrome(input);
static void IsPalindrome(string input)
{
    while (input != "END")
    {
        string polindrome = "";
            int number = int.Parse(input);
            while (number > 0)
            {
                polindrome += number % 10;
                number /= 10;
                if (number == 0) { break; }
            }
        if (input == polindrome) { Console.WriteLine("true"); } else Console.WriteLine("false");
        input = Console.ReadLine();
    }
}