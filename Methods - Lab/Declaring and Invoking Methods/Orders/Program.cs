static void totalPrice(double price, int quantity)
{ 
    Console.WriteLine($"{price*quantity:f2}");
}
string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
switch (product)
{
    case "coffee": totalPrice(1.50,quantity) ;break;
    case "water": totalPrice(1.00,quantity); break;
    case "coke": totalPrice(1.40,quantity); break;
    case "snacks":totalPrice(2.00,quantity); break;
}