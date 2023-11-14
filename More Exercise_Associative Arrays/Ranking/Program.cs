string input;
Dictionary<string,Person> List = new Dictionary<string,Person>();
while ((input = Console.ReadLine()) != "end of contests")
{
    string[] tokens = input.Split(":");
    string contest = tokens[0];
    string password = tokens[1];
}
string input1;
while ((input1=Console.ReadLine()) != "end of submissions")
{
    string[] lines = input1.Split("=>");
    string contest1 = lines[0];
    string password1 = lines[1];
    string username = lines[2];
    int points = int.Parse(lines[3]);
}
static bool IsValidContent(string content, List)
{
    if (List.ContainsKey(content))
    { return true; }
    else { return false; }
}
public class Person 
{
   public string Username;
   public int Points;

    public Person(string username, int points)
    {
        Username = username;
        Points = points;
    }
}
public override string ToString()
{
    return $"Best candidate is {Username} with total {Points} points.";
}