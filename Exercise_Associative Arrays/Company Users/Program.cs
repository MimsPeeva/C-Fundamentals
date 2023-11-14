string input;
Dictionary<string, Company> emplayees = new Dictionary<string, Company>();
while ((input = Console.ReadLine()) != "End")
{
    string[] lines = input.Split(" -> ");
    string CompanyName = lines[0];
    string EmployeeID = lines[1];
    if (!emplayees.ContainsKey(CompanyName))
    {
         emplayees.Add(CompanyName, new Company(CompanyName) );
    }
     emplayees[CompanyName].AddEmployee(EmployeeID); 
}
foreach (KeyValuePair<string, Company> item in emplayees)
{
    Console.WriteLine(item.Value);
}
public class Company
{
    public string Name;
    public List<string> Employees;

    public Company(string name)
    {
        Name = name;
        Employees = new List<string>();
    }
    public void AddEmployee(string employeeId)
    {
        if (!Employees.Contains(employeeId))
        {
            Employees.Add(employeeId);
        }
    }
    public override string ToString()
    {
        string result = $"{Name}\n";
        for (int i = 0; i < Employees.Count; i++)
        {
            result += $"-- {Employees[i]}\n";
        }

        return result.Trim();
    }
}
/*
SoftUni -> AA12345
SoftUni -> BB12345
Microsoft -> CC12345
HP -> BB12345
End
*/