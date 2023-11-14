using System.Text;

string input;
Dictionary<string,  Course> courseDictionary = new Dictionary<string, Course>();
while ((input = Console.ReadLine()) != "end")
{
    string[] lines = input.Split(" : ");
    string courseName = lines[0];
    string personName = lines[1];
    if (!courseDictionary.ContainsKey(courseName))
    { 
        Course course = new Course(courseName); 
        courseDictionary.Add(courseName, course);
    }
    courseDictionary[courseName].PersonName.Add(personName);
}
foreach (KeyValuePair<string, Course> item in courseDictionary)
{
    Console.WriteLine(item.Value);
}
public class Course
{
    string CourseName;
  public List<string> PersonName;

    public Course(string courseName)
    {
        CourseName = courseName;
        PersonName = new List<string>();
    }
    public override string ToString()
    {
        string result = $"{CourseName}: {PersonName.Count}\n";
        for (int i = 0; i < PersonName.Count; i++)
        {
            result += $"-- {PersonName[i]}\n";
        }
     
        return result.Trim();
    }
}
/*
Programming Fundamentals : John Smith
Programming Fundamentals : Linda Johnson
JS Core : Will Wilson
Java Advanced : Harrison White
end
*/