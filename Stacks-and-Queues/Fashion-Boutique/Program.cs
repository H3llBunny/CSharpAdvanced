using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int capacitySum = 0;
            int racks = 1;
            int valueSum = 0;

            while (clothes.Count > 0)
            {
                int clothing = clothes.Pop();
                
                if(clothing + capacitySum <= capacity)
                {
                    capacitySum += clothing;
                }
                else
                {
                    racks++;
                    capacitySum = 0;
                    capacitySum += clothing;
                }
            }

            Console.WriteLine(racks);
        }
    }
}