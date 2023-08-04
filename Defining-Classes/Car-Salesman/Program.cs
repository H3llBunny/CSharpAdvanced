namespace CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var engineList = new List<Engine>();
            var carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (token.Length == 2)
                {
                    string model = token[0];
                    int power = int.Parse(token[1]);
                    int displacement = 0;
                    string efficiency = "n/a";
                    engineList.Add(new Engine(model, power, displacement, efficiency));
                }
                else if (token.Length == 3)
                {
                    int number;

                    if (int.TryParse(token[2], out number))
                    {
                        string model = token[0];
                        int power = int.Parse(token[1]);
                        int displacement = number;
                        string efficiency = "n/a";
                        engineList.Add(new Engine(model, power, displacement, efficiency));
                    }
                    else
                    {
                        string model = token[0];
                        int power = int.Parse(token[1]);
                        int displacement = 0;
                        string efficiency = token[2];
                        engineList.Add(new Engine(model, power, displacement, efficiency));
                    }
                }
                else if (token.Length == 4)
                {
                    string model = token[0];
                    int power = int.Parse(token[1]);
                    int displacement = int.Parse(token[2]);
                    string efficiency = token[3];
                    engineList.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var token = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (token.Length == 2)
                {
                    string model = token[0];
                    string engineModel = token[1];
                    Engine engine = engineList.FirstOrDefault(x => x.Model == engineModel);
                    int weight = 0;
                    string color = "n/a";
                    var car = new Car(model, engine, weight, color);
                    carList.Add(car);
                }
                else if (token.Length == 3)
                {
                    int number;

                    if (int.TryParse(token[2], out number))
                    {
                        string model = token[0];
                        string engineModel = token[1];
                        Engine engine = engineList.FirstOrDefault(x => x.Model == engineModel);
                        int weight = number;
                        string color = "n/a";
                        var car = new Car(model, engine, weight, color);
                        carList.Add(car);
                    }
                    else
                    {
                        string model = token[0];
                        string engineModel = token[1];
                        Engine engine = engineList.FirstOrDefault(x => x.Model == engineModel);
                        int weight = 0;
                        string color = token[2];
                        var car = new Car(model, engine, weight, color);
                        carList.Add(car);
                    }
                }
                else if (token.Length == 4)
                {
                    string model = token[0];
                    string engineModel = token[1];
                    Engine engine = engineList.FirstOrDefault(x => x.Model == engineModel);
                    int weight = int.Parse(token[2]);
                    string color = token[3];
                    var car = new Car(model, engine, weight, color);
                    carList.Add(car);
                }
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");

                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }

                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");

                if (car.Weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }

                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}