using System;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double currentBalance = double.Parse(Console.ReadLine());
            double spendMoney = 0;
            string gameName = Console.ReadLine();
            while (gameName != "Game Time")
            {
                if(gameName != "OutFall 4"&& gameName!= "CS: OG" && gameName!= "Zplinter Zell"&&gameName != "Honored 2"&&gameName!= "RoverWatch"&&gameName!= "RoverWatch Origins Edition")
                    { Console.WriteLine("Not Found"); }
               else if (gameName == "OutFall 4"&&currentBalance>=39.99) { currentBalance -= 39.99; spendMoney += 39.99; Console.WriteLine($"Bought {gameName}"); }
                else if (gameName == "CS: OG" && currentBalance >= 15.99) { currentBalance -= 15.99; spendMoney += 15.99; Console.WriteLine($"Bought {gameName}"); }
                else if (gameName == "Zplinter Zell" && currentBalance >= 19.99) { currentBalance -= 19.99; spendMoney += 19.99; Console.WriteLine($"Bought {gameName}"); }
                else if (gameName == "Honored 2" && currentBalance >= 59.99) { currentBalance -= 59.99; spendMoney += 59.99; Console.WriteLine($"Bought {gameName}"); }
                else if (gameName == "RoverWatch" && currentBalance >= 29.99) { currentBalance -= 29.99; spendMoney += 29.99; Console.WriteLine($"Bought {gameName}"); }
                else if (gameName == "RoverWatch Origins Edition" && currentBalance >= 39.99) { currentBalance -= 39.99; spendMoney += 39.99; Console.WriteLine($"Bought {gameName}"); }
                else Console.WriteLine("Too Expensive");
                if (currentBalance == 0) { Console.WriteLine("Out of money!");break; }
                gameName = Console.ReadLine();
            }
          if(gameName=="Game Time")  Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
