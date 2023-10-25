using System.Diagnostics;

decimal sumWithoutTaxes = 0;
string input;
while (true)
{
    input = Console.ReadLine();
    if (input == "special" || input == "regular")
    {
        break;
    }
    decimal currentPrice = decimal.Parse(input);
    if (currentPrice <= 0)
    {
        Console.WriteLine("Invalid price!"); continue;
    }
        sumWithoutTaxes += currentPrice;    
}
if (sumWithoutTaxes == 0)
{ Console.WriteLine("Invalid order!"); }
else
{
    decimal sumTaxes = (20m / 100m) * sumWithoutTaxes;
    decimal sumWithTaxes = sumWithoutTaxes + sumTaxes;
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {sumWithoutTaxes:f2}$");
    Console.WriteLine($"Taxes: {sumTaxes:f2}$");
    Console.WriteLine("-----------");
    if (input == "special")
    {
        sumWithTaxes -= (sumWithTaxes * 10m) / 100m;
    }
    Console.WriteLine($"Total price: {sumWithTaxes:f2}$");
}
