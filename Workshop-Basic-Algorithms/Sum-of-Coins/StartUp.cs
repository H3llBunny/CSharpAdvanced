namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(",", "");
            //var availableCoins = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(int.Parse).ToList(); <- use this if first word is "Coins: "
            var availableCoins = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //var input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(int.Parse).ToArray(); <- use this if first word is "Sum: "
            //int targetSum = input2[0];
            int targetSum = int.Parse(Console.ReadLine());
            var neededCoins = new Dictionary<int, int>();

            try
            {
                neededCoins = ChooseCoins(availableCoins, targetSum);

                Console.WriteLine("Number of coins to take: {0}", neededCoins.Sum(x => x.Value));

                foreach (var coin in neededCoins.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            int currentSum = 0;
            var neededCoins = new Dictionary<int, int>();

            foreach (var coin in coins.OrderByDescending(x => x))
            {
                while (coin + currentSum <= targetSum)
                {
                    currentSum += coin;

                    if (neededCoins.ContainsKey(coin))
                    {
                        neededCoins[coin]++;
                    }
                    else
                    {
                        neededCoins.Add(coin, 1);
                    }
                }
            }

            if (currentSum == targetSum)
            {
                return neededCoins;
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
}