using System.Text.RegularExpressions;
decimal totalIncome = 0;
string input;
while ((input = Console.ReadLine()) != "end of shift")
{
    string pattern = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+(?:\.\d+)?)\$";
    if (Regex.IsMatch(input, pattern) == false)
    { continue; }
    Match match = Regex.Match(input, pattern);
    Order order = new Order();
    order.Name = match.Groups[1].Value;
    order.Product = match.Groups[2].Value;
    order.Quantity = uint.Parse(match.Groups[3].Value);
    order.Price = decimal.Parse(match.Groups[4].Value);
    totalIncome += order.TotalPrice;
    Console.WriteLine($"{order.Name}: {order.Product} - {order.TotalPrice:f2}");
}
Console.WriteLine($"Total income: {totalIncome:f2}");

class Order
{
    public string Name;
    public string Product;
    public uint Quantity;
    public decimal Price;
    public decimal TotalPrice
    {
        get
        {
            return Quantity * Price;
        }
    }
}