using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_of_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = Console.ReadLine()
                                 .Split(", ")
                                 .Select(int.Parse)
                                 .ToArray();

            int target = int.Parse(Console.ReadLine());

            SortedSet<int> helpCoins = new SortedSet<int>(coins);

            StringBuilder sb = new StringBuilder();

            int coinsCounter = 0;

            while (target > 0 && helpCoins.Count > 0)
            {
                int maxCoin = helpCoins.Max();

                helpCoins.Remove(maxCoin);

                int counter = target / maxCoin;

                coinsCounter += counter;

                target -= (counter * maxCoin);

                if(counter > 0)
                {
                    sb.AppendLine($"{counter} coin(s) with value {maxCoin}");
                }
            }

            if (target == 0)
            {
                Console.WriteLine($"Number of coins to take: {coinsCounter}");
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
