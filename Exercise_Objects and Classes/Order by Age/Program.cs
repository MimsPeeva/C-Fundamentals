using System;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

internal class Ordering
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }

    public Ordering(string name, string id, int age)
    {
        Id = id;
        Age = age;
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name} with ID: {Id} is {Age} years old.";
    }
}

internal class Program
{
    static void Main()
    {
        List<Ordering> list = new List<Ordering>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();

            string name = arguments[0];
            string id = arguments[1];
            int age = int.Parse(arguments[2]);

            Ordering personFound = list.FirstOrDefault(person => person.Id == id);

            if (personFound != null)
            {
                personFound.Age = age;
                personFound.Name = name;
            }
            else
            {
                list.Add(new Ordering(name, id, age));
            }
        }

        List<Ordering> orderedPersons = list.OrderBy(person => person.Age).ToList();
        foreach (Ordering person in orderedPersons)
        {
            Console.WriteLine(person);
        }
    }
}
