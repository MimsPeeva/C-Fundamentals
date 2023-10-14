List<int> integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] lineTokens = input.Split();
    string command = lineTokens[0];
    if (command == "Add")
    {
        int number = int.Parse(lineTokens[1]);
        integers.Add(number);
    }
    else if (command == "Insert")
    {
        int n1 = int.Parse(lineTokens[1]);
        int n2 = int.Parse(lineTokens[2]);
        if (IsnotInRange(n2, integers.Count))
        { Console.WriteLine("Invalid index"); }
        else
        { integers.Insert(n2, n1); }
    }
    else if (command == "Remove")
    {
        int n = int.Parse(lineTokens[1]);
        if (IsnotInRange(n, integers.Count))
        { Console.WriteLine("Invalid index"); }
        else
        { integers.RemoveAt(n); }
    }
    else if (command == "Shift")
    {
        string direction = lineTokens[1];
        int n = int.Parse(lineTokens[2]);
        n = n % integers.Count;
        if (direction == "left")
        {
            List<int> ShiftedLeftPart = integers.GetRange(0, n);
            integers.RemoveRange(0, n);
            integers.InsertRange(integers.Count, ShiftedLeftPart);
        }
        else if (direction == "right")
        {
            List<int> ShiftedRightPart = integers.GetRange(integers.Count-n, n);
            integers.RemoveRange(integers.Count-n,n);
            integers.InsertRange(0, ShiftedRightPart);
        }
    }
}
Console.WriteLine(string.Join(" ", integers));
static bool IsnotInRange(int n, int listCount)
{ return n < 0 || n >= listCount; }