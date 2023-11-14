string input;
List<Box> boxes = new List<Box>();
while ((input = Console.ReadLine()) != "end")
{
    string[] lineTokens = input.Split();
    string serialN = lineTokens[0];
    string itemName = lineTokens[1];
    int itemQuantity = int.Parse(lineTokens[2]);
    double itemPrice = double.Parse(lineTokens[3]);
    Box box = new Box();
    box.SerialNumber = serialN;
    box.ItemQuantity = itemQuantity;
    box.Item = itemName;
    box.PriceForBox=itemPrice;
    box.TotalPrice = itemQuantity * itemPrice;
      boxes.Add(box);
}
List<Box> sortedBox = boxes.OrderByDescending(box => box.TotalPrice).ToList();
foreach (Box box in sortedBox)
{

        Console.WriteLine($"{box.SerialNumber}");
        Console.WriteLine($"-- {box.Item} - ${box.PriceForBox:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.TotalPrice:f2}");
}

public class Box
{
    public string SerialNumber { get; set; }
    public string Item { get; set; }
    public int ItemQuantity { get; set; }
    public double PriceForBox { get; set; }
    public double TotalPrice { get; set; }
}
