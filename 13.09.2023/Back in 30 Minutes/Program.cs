﻿using System;

namespace Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;
            if (minutes > 59)
            { hours ++;
                minutes = minutes %60; }
            if (hours > 23) { hours = 0; }
            if (minutes < 10) { Console.WriteLine($"{hours}:0{minutes}"); }
           else Console.WriteLine($"{hours}:{minutes}");
        }
    }
}
