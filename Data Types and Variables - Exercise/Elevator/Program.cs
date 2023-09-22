using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            if (person > capacity)
            {
                int courses = person / capacity;
                int p = capacity * courses;
                person -= p;
                if (person > 0) { courses++; }
                Console.WriteLine(courses);
            }
            else Console.WriteLine("1");
        }
    }
}
