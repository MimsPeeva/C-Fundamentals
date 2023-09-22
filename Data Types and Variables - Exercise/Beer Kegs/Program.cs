using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           double maxVolume = 0;
            string maxVolumeModel = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume >= maxVolume) { maxVolume = volume; maxVolumeModel = model; }
                
            }

            Console.WriteLine(maxVolumeModel);
        }
    }
}
