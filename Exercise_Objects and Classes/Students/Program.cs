using System.Collections.Immutable;

int stNumber = int.Parse(Console.ReadLine());
List<Student> list = new List<Student>();
for (int i = 0; i < stNumber; i++)
{
    string[] info = Console.ReadLine()
        .Split()
        .ToArray();
    Student student = new Student();
    student.FirstName = info[0];
    student.LastName = info[1];
    student.Grade = double.Parse(info[2]);
    list.Add(student);
}
List<Student> sortedList= list.OrderByDescending(student => student.Grade).ToList();
Console.WriteLine(string.Join("\n", sortedList));
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:f2}";
    }
    //public Student(string firstName, string lastName, double grade)
    //{ 
    //    FirstName = firstName;
    //    LastName = lastName;
    //    Grade = grade;
    //}

}
/*
4
Lakia Eason 3.90
Prince Messing 5.49
Akiko Segers 4.85
Rocco Erben 6.00
 */