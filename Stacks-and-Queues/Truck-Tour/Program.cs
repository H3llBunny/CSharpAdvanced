using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    internal class PetrolPump
    {
        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }

        public int Petrol { get; set; }
        public int Distance { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int pumpCount = int.Parse(Console.ReadLine());
            var pumps = new Queue<PetrolPump>();
            int truckPetrol = 0;
            int pumpIndex = 0;
            bool check = false;

            for (int i = 0; i < pumpCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var pump = new PetrolPump(input[0], input[1]);
                pumps.Enqueue(pump);
            }

            while (!check)
            {
                foreach (var pump in pumps)
                {
                    if (pump.Petrol >= pump.Distance || truckPetrol >= pump.Distance)
                    {
                        truckPetrol += pump.Petrol;
                        truckPetrol -= pump.Distance;
                        check = true;
                    }
                    else if (pump.Petrol <= pump.Distance || truckPetrol <= pump.Distance)
                    {
                        check = false;
                        pumps.Enqueue(pumps.Dequeue());
                        pumpIndex++;
                        break;
                    }
                }
            }

            Console.WriteLine(pumpIndex);
        }
    }
}