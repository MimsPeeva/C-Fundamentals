List<Students>students = new List<Students>();
string input;
while((input=Console.ReadLine())!="end")
{
    string[] lineTokens = input.Split();
    string firstN = lineTokens[0];
    string lastN = lineTokens[1];
    int age = int.Parse(lineTokens[2]);
    string homeTown = lineTokens[3];
    Students student = new Students();
    student.LastName = lastN;
    student.FirstName = firstN;
    student.Age = age;
    student.HomeTown = homeTown;
    students.Add(student);
}
string cityName = Console.ReadLine();
foreach(Students student in students)
{ 
    if(cityName==student.HomeTown)
    {
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");

    }
}
public class Students
{
   
    public string  FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

}