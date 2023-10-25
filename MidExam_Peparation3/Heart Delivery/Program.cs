using System.Runtime.CompilerServices;

List<string> listNeighborhood = Console.ReadLine()
    .Split('@')
    .ToList();
string input;
while ((input = Console.ReadLine()) != "Love!")
{
    string[] line = input.Split();
    string command = line[0];
    int length = int.Parse(line[1]);
    int currentIndex = int.Parse(listNeighborhood[length]);
    /*if (length > listNeighborhood.Count)
    {
        length = 
    }*/
    if (currentIndex == 0)
    {
        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");

    }
    else
    {
        currentIndex -= 2;
        if (currentIndex == 0)
        { Console.WriteLine($"Place {currentIndex} has Valentine's day."); }
    }
}