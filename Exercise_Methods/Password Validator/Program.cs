string password = Console.ReadLine();
if (CheckLength(password) && CheckDigitsNumber(password) && CheckElements(password))
{ Console.WriteLine("Password is valid"); }
else if (!CheckDigitsNumber(password))
{ Console.WriteLine("Password must have at least 2 digits");}
else if (!CheckElements(password))
{ Console.WriteLine("Password must consist only of letters and digits"); }
else if (!CheckLength(password))
{ Console.WriteLine("Password must be between 6 and 10 characters"); }
static bool CheckLength(string password)
{
    bool isValid = false;
    if (password.Length >= 6 && password.Length <= 10)
    {
        isValid = true;
    }
    return isValid;
}
static bool CheckElements(string input)
{
    bool isValid = true;
    for (int i = 0; i < input.Length; i++)
    {
        char ch = input[i];
        if (ch >= 48 && ch <= 57 || ch >= 65 && ch <= 90 || ch >= 97 && ch <= 122)
        { continue; }
        else { isValid = false;break; }
    }
    return isValid;
}
static bool CheckDigitsNumber(string input)
{
    bool isValid = true;
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        char ch = input[i];
        if (ch >= 48 && ch <= 57) { count++; }
    }
    if (count < 2) { isValid = false; }
    return isValid;
}
