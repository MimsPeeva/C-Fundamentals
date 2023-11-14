List<Students> students = new List<Students>();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] lineTokens = input.Split();
    string firstName = lineTokens[0];
    string lastName = lineTokens[1];
    int age = int.Parse(lineTokens[2]);
    string homeTown = lineTokens[3];

    Students student = new Students();
    student.FirstName = firstName;
    student.LastName = lastName;
    student.Age = age;
    student.HomeTown = homeTown;

    int index = IsExist(firstName, lastName, students);
    if (index != -1)
    {
        students[index].HomeTown = homeTown;
        students[index].Age = age;
        continue;
    }
        students.Add(student);

    
}
string cityName = Console.ReadLine();
foreach (Students student in students)
{
    if (cityName == student.HomeTown)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

    }
}
static int IsExist(string firstName, string lastName, List<Students> students)
{
    for(int i =0; i<students.Count;i++)
    {
        if (students[i].FirstName == firstName && students[i].LastName == lastName)
        { return i; }
    }
    return -1;

}
public class Students
{
  

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

}