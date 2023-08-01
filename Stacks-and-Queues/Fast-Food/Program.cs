using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            var orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (orders.Peek() <= quantity)
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: {string.Join(' ', orders)}");
            }
        }
    }
}
