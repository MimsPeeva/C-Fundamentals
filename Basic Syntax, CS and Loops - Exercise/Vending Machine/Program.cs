using System;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
           
            double money = 0;
            while (coins != "Start")
            {
                double amountOfCoins = double.Parse(coins);
                if (amountOfCoins == 0.1)
                {
                    money += 0.1;
                }
                else if (amountOfCoins == 0.2)
                {
                    money += 0.2;
                }
                else if (amountOfCoins == 0.5)
                {
                    money += 0.5;
                }
                else if (amountOfCoins == 1)
                {
                    money += 1;
                }
                else if (amountOfCoins == 2)
                {
                    money += 2;
                }
                else
                { Console.WriteLine($"Cannot accept {coins}"); }
                coins = Console.ReadLine();
            }
                string product = Console.ReadLine();
                while (product != "End")
                {
                    if (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke")
                    {
                        if (product == "Nuts" && money >= 2) { money -= 2; Console.WriteLine($"Purchased {product.ToLower()}"); }
                        else if (product == "Water" && money >= 0.7) { money -= 0.7; Console.WriteLine($"Purchased {product.ToLower()}"); }
                        else if (product == "Crisps" && money >= 1.5) { money -= 1.5; Console.WriteLine($"Purchased {product.ToLower()}"); }
                        else if (product == "Soda" && money >= 0.8) { money -= 0.8; Console.WriteLine($"Purchased {product.ToLower()}"); }
                        else if (product == "Coke" && money >= 1) { money -= 1.0; Console.WriteLine($"Purchased {product.ToLower()}"); }
                        else { Console.WriteLine("Sorry, not enough money"); }
                    }
                    else Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                }
            Console.WriteLine($"Change: {money:f2}");
        }
           
        }
        }
    

