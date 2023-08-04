using System;
using System.Diagnostics;

namespace Speed_Racing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                carList.Add(car);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var token = command.Split();
                string carModel = token[1];
                double distance = double.Parse(token[2]);

                TravelDistance(carList, carModel, distance);
            }

            PrintCarList(carList);
        }

        public static void TravelDistance(List<Car> carList, string carModel, double distance)
        {
            foreach (var car in carList)
            {
                if (car.Model == carModel)
                {
                    if (car.FuelAmount >= distance * car.FuelConsumptionPerKm)
                    {
                        car.FuelAmount -= distance * car.FuelConsumptionPerKm;
                        car.TravelledDistance += distance;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }
        }

        public static void PrintCarList(List<Car> carList)
        {
            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

            return;
        }
    }
}
