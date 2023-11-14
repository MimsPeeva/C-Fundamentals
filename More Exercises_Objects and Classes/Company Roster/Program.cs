int n = int.Parse(Console.ReadLine());
List<Emplayee> employee = new List<Emplayee>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    double salary = double.Parse(input[1]);
    string department = input[2];
    employee.Add(new Emplayee(name, salary, department));
}
public class Emplayee
{
    public Emplayee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string Name { get; set; }
    public double Salary { get; set; }
   public string Department { get; set; }
}