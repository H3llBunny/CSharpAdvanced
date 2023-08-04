using System;

namespace RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split();
                string model = token[0];
                var engine = new Engine(int.Parse(token[1]), int.Parse(token[2]));
                var cargo = new Cargo(int.Parse(token[3]), token[4]);
                var tire = new Tire(double.Parse(token[5]), int.Parse(token[6])
                    , double.Parse(token[7]), int.Parse(token[8])
                    , double.Parse(token[9]), int.Parse(token[10])
                    , double.Parse(token[11]), int.Parse(token[12]));
                var car = new Car(model, engine, cargo, tire);
                carList.Add(car);
            }

            string cargoType = Console.ReadLine();

            if (cargoType == "fragile")
            {
                foreach (var car in carList.Where(x => x.Cargo.CargoType == "fragile"))
                {
                    if (car.Tire.Tire1Pressure < 1 || car.Tire.Tire2Pressure < 1
                        || car.Tire.Tire3Pressure < 1 || car.Tire.Tire4Pressure < 1)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (cargoType == "flammable")
            {
                foreach (var car in carList.Where(x => x.Cargo.CargoType == "flammable"))
                {
                    if (car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}