
//var planets = list.Where(m => m.Type == "A")
//        .OrderBy(m => m.PlanetName)
//        .ToList();

//Console.WriteLine($"Attacked planets: {planets.Count}");
//planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

//planets = list.Where(m => m.Type == "D")
//    .OrderBy(m => m.PlanetName)
//    .ToList();

//Console.WriteLine($"Destroyed planets: {planets.Count}");
//planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

class Message
{
    public string PlanetName { get; set; }
    public uint Population { get; set; }
    public string Type { get; set; }
    public uint Soldiers { get; set; }
}
/*
2
STCDoghudd4=63333$D$0A53333
EHfsytsnhf?8555&I&2C9555SR
 */