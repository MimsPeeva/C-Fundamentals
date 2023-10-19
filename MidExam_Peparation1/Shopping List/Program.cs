using System.Runtime.CompilerServices;

int waitingPeople = int.Parse(Console.ReadLine());
int[] wagons = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
for (int i = 0; i < wagons.Length; i++)
{
    int currentWagon = wagons[i];
    if (currentWagon < 4)
    {
        int emptySeats = 4 - wagons[i];
        waitingPeople -= emptySeats;
        if (waitingPeople<0) 
        {
            wagons[i] = 4 - Math.Abs(waitingPeople);
            Console.WriteLine("The lift has empty spots!");
            PrintWagons(wagons);
            return;
        }
        wagons[i]= 4;
    }
}
if (waitingPeople != 0)
{
    Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
}
PrintWagons(wagons);

static void PrintWagons(int[] wagons)
{
    Console.WriteLine(string.Join(" ", wagons));
}
