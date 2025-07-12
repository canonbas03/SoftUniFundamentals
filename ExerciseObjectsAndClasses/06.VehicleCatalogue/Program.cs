namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                double horsePower = double.Parse(arguments[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
            }
            List<string> wantedVehicles = new List<string>();
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                wantedVehicles.Add(input);
            }

            //vehicles = vehicles.OrderBy(v => v.Model).ToList();
            foreach (string wvehicle in wantedVehicles)
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if(wvehicle.Equals(vehicles[i].Model) && vehicles[i].Type == "car")
                    {
                        Console.WriteLine(vehicles[i]);
                    }
                }
            }
            foreach (string wvehicle in wantedVehicles)
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (wvehicle.Equals(vehicles[i].Model) && vehicles[i].Type == "truck")
                    {
                        Console.WriteLine(vehicles[i]);
                    }
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {AverageOfVehicle(vehicles, "car"):f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {AverageOfVehicle(vehicles, "truck"):f2}.");
        }

        public static double AverageOfVehicle(List<Vehicle> vehicles, string type)
        {
            double totalHP = 0;
            int count = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    totalHP += vehicle.HorsePower;
                    count++;
                }
            }

            if (count == 0) return 0;

            return totalHP / count;
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            string result = $"Type: {char.ToUpper(Type[0]) + Type.Substring(1)}\n";
            result += $"Model: {Model}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {HorsePower}";
            return result;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
}