List<City> list = new List<City>();
string input;
while ((input=Console.ReadLine())!= "Sail")
{
    string[] lines = input.Split("||");
    string cityName = lines[0];
    decimal population = decimal.Parse(lines[1]);
    decimal gold = decimal.Parse(lines[2]);
    City city = list.FirstOrDefault(x=>x.CityName == cityName);
    if (city is not null)
    {
        city.Population += population;
        city.Gold += gold;
        continue;
    }
    list.Add(new City
    {
        CityName = cityName,
        Population = population,
        Gold = gold
    }) ;
}
string events;
while ((events = Console.ReadLine()) != "End")
{
    string[] tokens = events.Split("=>");
    string command = tokens[0];
        string cityName = tokens[1];
    City targetCity = list.FirstOrDefault(x => x.CityName == cityName);
    if (command == "Plunder")
    {
        decimal population = decimal.Parse(tokens[2]);
       decimal gold = decimal.Parse(tokens[3]);
       
        targetCity.Population -= population;
            targetCity.Gold -= gold;
            Console.WriteLine($"{targetCity.CityName} plundered! {gold} gold stolen, {population} citizens killed.");
        if (targetCity.Population <= 0 || targetCity.Gold <= 0)
        {
            Console.WriteLine($"{targetCity.CityName} has been wiped off the map!");
            list.Remove(targetCity);
            continue;
        }
        
    }
    else if (command== "Prosper")
    {
        decimal n = decimal.Parse(tokens[2]);
        if (n < 0) { Console.WriteLine("Gold added cannot be a negative number!"); continue; }
        else
        {
            targetCity.Gold +=  n;
            Console.WriteLine($"{n} gold added to the city treasury. {cityName} now has {targetCity.Gold} gold.");
        }
    }
}
if (list.Count > 0)
{
    Console.WriteLine($"Ahoy, Captain! There are {list.Count} wealthy settlements to go to:");
    foreach (var item in list)
    {
        Console.WriteLine($"{item.CityName} -> Population: {item.Population} citizens, Gold: {item.Gold} kg");
    }
}
else { Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!"); }
/*
Tortuga||345000||1250
Santo Domingo||240000||630
Havana||410000||1100
Sail
Plunder=>Tortuga=>75000=>380
Prosper=>Santo Domingo=>180
End
 */
/*
Nassau||95000||1000
San Juan||930000||1250
Campeche||270000||690
Port Royal||320000||1000
Port Royal||100000||2000
Sail
Prosper=>Port Royal=>-200
Plunder=>Nassau=>94000=>750
Plunder=>Nassau=>1000=>150
Plunder=>Campeche=>150000=>690
End
*/
public class City
{
    public string CityName { get; set; }
   public decimal Population { get; set; }
    public decimal Gold { get; set; }

}
