using System.Reflection;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split("/");

                string type = arguments[0];
                string brand = arguments[1];
                string model = arguments[2];

                if (type == "Car")
                {
                    string horsePow = arguments[3];
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePow;
                    catalogue.Cars.Add(car);
                }
                else
                {
                    string weight = arguments[3];
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;
                    catalogue.Trucks.Add(truck);
                }
            }

            catalogue.Cars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
            catalogue.Trucks = catalogue.Trucks.OrderBy(t => t.Brand).ToList();
            if (catalogue.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalogue.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalogue.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}