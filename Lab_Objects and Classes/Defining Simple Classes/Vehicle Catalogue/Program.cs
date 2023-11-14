using System.Reflection;
Catalog catalog = new Catalog();
string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] tokens = input.Split('/');
    string Type = tokens[0];
    string brand = tokens[1];
    string model = tokens[2];
   double HorsePowerOrWeight = double.Parse(tokens[3]);
    if (Type == "Truck")
    {
        Truck truck = new Truck();
        truck.TruckBrand = brand;
        truck.TruckModel = model;
        truck.TruckWeight = HorsePowerOrWeight;
        catalog.Trucks.Add(truck);
    }
    else
    {
        Car car = new Car();
        car.CarBrand = brand;
        car.CarModel = model;
        car.CarHorsePower = HorsePowerOrWeight;
        catalog.Cars.Add(car);
    }
}
if(catalog.Cars.Count>0)
{
    Console.WriteLine("Cars:");
    foreach (Car car in catalog.Cars.OrderBy(car => car.CarModel))
    {
        Console.WriteLine($"{car.CarBrand}: {car.CarModel} - {car.CarHorsePower}hp");
    }
}
if (catalog.Trucks.Count > 0)
{
    Console.WriteLine("Trucks:");
    foreach (Truck truck in catalog.Trucks.OrderBy(truck => truck.TruckBrand))
    {
        Console.WriteLine($"{truck.TruckBrand}: {truck.TruckModel} - {truck.TruckWeight}kg");
    }
}
public class Truck
{
  public string TruckBrand { get; set; }
   public string TruckModel { get; set; }
    public double TruckWeight { get; set; }
}
public class Car
{
    public string CarBrand { get; set; }
    public string CarModel { get; set; }
    public double CarHorsePower { get; set; }
}
public class Catalog
{
    public List<Car> Cars {get;set;}
    public List<Truck> Trucks { get; set; }
    public Catalog()
    { Cars = new List<Car>();
      Trucks = new List<Truck>();
    }

}
/*
Car / Subaru / Impreza / 152
Car / Peugeot / 307 / 109
end
    */