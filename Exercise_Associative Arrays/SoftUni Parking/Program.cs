int n = int.Parse(Console.ReadLine());
string input;
Dictionary<string, Person> users = new Dictionary<string, Person>();
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine();
    string[] lines = input.Split();
    string command = lines[0];
    string name = lines[1];
    if (command == "register")
    {
    string carNumber = lines[2];
    Person person = new Person (name, carNumber);
        if (!users.ContainsKey(name))
        {
            users.Add(person.Name, person);
            Console.WriteLine($"{person.Name} registered {person.CarNumber} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {person.CarNumber}");
        }
    }
    if(command == "unregister")
    {
        if (users.ContainsKey(name))
        {

            users.Remove(name);
            Console.WriteLine($"{name} unregistered successfully"); 
        }
        else
        {
            Console.WriteLine($"ERROR: user {name} not found");
        }
    }
}
foreach (KeyValuePair<string,Person> person in users)
{
    Console.WriteLine(person.Value);
}
public class Person
{
    public Person( string name, string carNumber)
    {
        Name = name;
        CarNumber = carNumber;
    }

    public string Name { get; set; }
    public string CarNumber { get; set; }
    public override string ToString()
    {
        return $"{Name} => {CarNumber}";
    }
}
/*
5
register John CS1234JS
register George JAVA123S
register Andy AB4142CD
register Jesica VR1223EE
unregister Andy
*/