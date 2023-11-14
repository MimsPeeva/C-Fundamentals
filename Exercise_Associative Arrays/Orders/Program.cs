string input;
Dictionary<string, Product> list = new Dictionary<string, Product>();
double sum = 0;
int itemQuantity = 0;
while((input=Console.ReadLine())!="buy")
{
    string[] tokens = input.Split();
    string item = tokens[0];
    double price = double.Parse(tokens[1]);
    int quantity = int.Parse(tokens[2]);
    Product product = new Product(item, price, quantity);

    if (!list.ContainsKey(item))
    {
        list.Add(product.Name, product);

    }
    else
    {
        list[item].Update(product.Price, product.Quantity);
    }
}
foreach (KeyValuePair<string, Product> productPair in list)
{
 
    Console.WriteLine(productPair.Value);
}
public class Product
{
    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
public void Update(double price, int quantity)
{
    Price = price;
    Quantity += quantity;
}
    public double GetTotal ()
{ return Price * Quantity; }
    public override string ToString()
    {
        return $"{Name} -> {GetTotal():f2}";
    }
}

/*
Beer 2.40 350
Water 1.25 200
IceTea 5.20 100
Beer 1.20 200
IceTea 0.50 120
buy
*/