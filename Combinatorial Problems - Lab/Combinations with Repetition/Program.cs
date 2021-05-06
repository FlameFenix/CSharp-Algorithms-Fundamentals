using System;
using System.Linq;

namespace Combinations_with_Repetition
{
    class Program
    {
        static string[] elements;
        static string[] combinations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();

            int k = int.Parse(Console.ReadLine());

            combinations = new string[k];

            Combinations(0, 0);

        }

        static void Combinations(int index, int loopIdx)
        {
            if(index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = loopIdx; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                Combinations(index + 1, i);
            }
        }
    }
}
