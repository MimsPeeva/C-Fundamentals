using System.Text;

internal class Program
{
        static List<Car> carList = new List<Car>();
    private static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfCars; i++)
        {
            string[] input = Console.ReadLine().Split("|");
            string carName = input[0];
            uint mileage = uint.Parse(input[1]);
            uint fuel = uint.Parse(input[2]);
            carList.Add(new Car(carName, mileage, fuel));
        }
        string newInput;
        while ((newInput = Console.ReadLine()) != "Stop")
        {
            string[] lines = newInput.Split(" : ");
            string name = lines[1];
            if (lines[0] == "Drive")
            {
                uint distance = uint.Parse(lines[2]);
                uint fuel = uint.Parse(lines[3]);
                Drive(name, distance, fuel);
            }
            else if (lines[0] == "Refuel")
            {
                uint fuel = uint.Parse(lines[2]);
                Refuel(name, fuel);
            }
            else if (lines[0] == "Revert")
            {
                uint kilometers = uint.Parse(lines[2]);
                Revert(name,kilometers);
            }
        }
        carList.ForEach(car => Console.WriteLine(car));
    }
    static void Drive(string name, uint distance, uint fuel)
        {
            Car foundCar = carList.FirstOrDefault(car=>car.CarName==name);
            if (foundCar==null)
            { return; }
            if (foundCar.Mileage >= distance && foundCar.Fuel >= fuel)
            {
                Console.WriteLine($"{foundCar.CarName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                foundCar.Mileage += distance;
                foundCar.Fuel -= fuel;
        if (foundCar.Mileage > 100000)
        {
            Console.WriteLine($"Time to sell the {foundCar.CarName}!");
            carList.Remove(foundCar);
        }
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }

   static void Revert(string name, uint kilometers)
    {
        Car foundCar = carList.FirstOrDefault(car => car.CarName == name);
        if (foundCar == null) { return; }
        uint revert = foundCar.Revert(kilometers);
        if (foundCar.Mileage < 10000) { foundCar.Mileage = 10000; return; }
        Console.WriteLine($"{foundCar.CarName} mileage decreased by {revert} kilometers");
    }

    static void Refuel(string name, uint fuel)
    {
        Car foundCar = carList.FirstOrDefault(car => car.CarName == name);
        if (foundCar == null) { return; }
        uint refuel = foundCar.Refuel(fuel);
        Console.WriteLine($"{foundCar.CarName} refueled with {refuel} liters");
    }
}

public class Car
{
    public Car(string carName, uint mileage, uint fuel)
    {
        CarName = carName;
        Mileage = mileage;
        Fuel = fuel;
    }
    public uint Refuel(uint fuel)
        {
        uint recharged = Math.Min(fuel, 75 -Fuel );
        Fuel+= recharged;
        return recharged;
    }

    public uint Revert(uint kilometers)
    {
        
        Mileage -= kilometers;
        return kilometers;
    }
    public override string ToString()
    {
        return $"{CarName} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
    }
    public string CarName { get; set; }
    public uint Mileage { get; set; }
    public uint Fuel { get; set; }
}
/*
3
Audi A6|38000|62
Mercedes CLS|11000|35
Volkswagen Passat CC|45678|5
Drive : Audi A6 : 543 : 47
Drive : Mercedes CLS : 94 : 11
Drive : Volkswagen Passat CC : 69 : 8
Refuel : Audi A6 : 50
Revert : Mercedes CLS : 500
Revert : Audi A6 : 30000
Stop

4
Lamborghini Veneno|11111|74
Bugatti Veyron|12345|67
Koenigsegg CCXR|67890|12
Aston Martin Valkryie|99900|50
Drive : Koenigsegg CCXR : 382 : 82
Drive : Aston Martin Valkryie : 99 : 23
Drive : Aston Martin Valkryie : 2 : 1
Refuel : Lamborghini Veneno : 40
Revert : Bugatti Veyron : 2000
Stop
 */