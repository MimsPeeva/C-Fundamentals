List <int> passengersNumber = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
int maxCapacityOfWagon = int.Parse(Console.ReadLine());
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] lineTokens = input.Split(' ').ToArray();
    string command = lineTokens[0];
    if (command == "Add")
    {
        int number = int.Parse(lineTokens[1]); 
        passengersNumber.Add(number);
    }
    else
    {
        int n1 = int.Parse(lineTokens[0]);
        for (int i = 0; i < passengersNumber.Count; i++)
        {
            if (passengersNumber[i]+n1<=maxCapacityOfWagon)
            {
                passengersNumber[i]+=n1;
                break;
            }
        }
       
    }
}
Console.WriteLine(string.Join(" ", passengersNumber));
