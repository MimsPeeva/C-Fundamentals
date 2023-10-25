int employee1 = int.Parse(Console.ReadLine());
int employee2 = int.Parse(Console.ReadLine());
int employee3 = int.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
int sumEmployers = employee1 + employee2 + employee3;
double hours = studentsCount*1.0 / sumEmployers;
hours = Math.Ceiling(hours);
for (int i = 1; i <= hours; i++)
{
if (i % 4 == 0)
{
    hours++; 
}
}
Console.WriteLine($"Time needed: {hours}h.");