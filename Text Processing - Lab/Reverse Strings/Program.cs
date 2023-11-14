string input = string.Empty;
string reversed = string.Empty; 
while ((input = Console.ReadLine()) != "end")
{
for (int i = input.Length-1; i >= 0; i--)
{
    reversed +=input[i];
}
Console.WriteLine($"{input} = {reversed}");
    reversed = string.Empty;
}
