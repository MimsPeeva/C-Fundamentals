using System.Xml.Linq;

int n = int.Parse(Console.ReadLine());
Dictionary<string, Student> students = new Dictionary<string, Student>();
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    decimal grade = decimal.Parse(Console.ReadLine());
    if (!students.ContainsKey(name))
    {
       // Student student = new Student(name);
        students.Add(name, new Student(name));
    }
   
    students[name].Grade.Add(grade);
    
}
IEnumerable<KeyValuePair<string, Student>> filteredStudents = students.Where(g => g.Value.Grade.Average() >= 4.50m);
foreach (KeyValuePair<string,Student> item in students)
{
    Console.WriteLine(item.Value);
}
public class Student
{
    public string Name;
    public List<decimal>Grade;

    public Student(string name)
    {
        Name = name;
        Grade = new List<decimal>();
    }
  
    public override string ToString()
    {
       
       
        return $"{Name} -> {Grade.Average():f2}";
    }
}
/*//working code
int line = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < line; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                    students[student] = new List<double>();

                students[student].Add(grade);
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}",students
                .Where(x => (x.Value.Sum() / x.Value.Count) >= 4.50)
                .OrderByDescending(x => x.Value.Sum() / x.Value.Count)
                .Select(x => $"{x.Key} -> {x.Value.Sum() / x.Value.Count():f2}")));
*/