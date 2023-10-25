int days = int.Parse(Console.ReadLine());
int countPlayers = int.Parse(Console.ReadLine());
double groupEnergy = double.Parse(Console.ReadLine());
double waterForOne = double.Parse(Console.ReadLine());
double foodForOne = double.Parse(Console.ReadLine());

double totalWater = days * countPlayers * waterForOne;
double totalFood = days * countPlayers * foodForOne;
int waterD = 0;
int foodD = 0;
for (int i = 0; i < days; i++)
{
    double energyInput = double.Parse(Console.ReadLine());
    groupEnergy -= energyInput;
    if (groupEnergy <= 0)
    {
        break;
    }
    waterD++;
    foodD++;
    if (waterD % 2 == 0)
    {
        totalWater -= totalWater * 0.3;
        groupEnergy += groupEnergy * 0.05;
    }
    if (foodD % 3 == 0)
    {
        groupEnergy += groupEnergy * 0.1;
        totalFood -= totalFood / countPlayers;
    }
}
if (groupEnergy > 0)
{
    Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
}
else
{
    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
}