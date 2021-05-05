using System;
using System.Collections.Generic;
using System.Linq;

namespace Set_Cover
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] originalSet = Console.ReadLine()
                                       .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

            int numberOfOperations = int.Parse(Console.ReadLine());

            HashSet<int[]> sets = new HashSet<int[]>();

            for (int i = numberOfOperations - 1; i >= 0; i--)
            {
                int[] currentSet = Console.ReadLine()
                                          .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

                sets.Add(currentSet);
            }

            HashSet<int> universe = new HashSet<int>(originalSet);

            HashSet<int[]> selectedSets = new HashSet<int[]>();

            while (universe.Count > 0)
            {
                int[] currentSet = sets.OrderByDescending(x => x.Count(x => universe.Contains(x))).First();

                selectedSets.Add(currentSet);

                sets.Remove(currentSet);

                foreach (var num in currentSet)
                {
                    universe.Remove(num);
                }
            }

            Console.WriteLine($"Sets to take ({selectedSets.Count}):");

            foreach (var item in selectedSets)
            {
                Console.WriteLine(string.Join(", ", item));
            }

        }
    }
}
