using System;

namespace Combinations_with_Repetition
{
    class Program
    {
        static int[] elements;
        static int[] combinations;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            elements = new int[n];
            combinations = new int[k];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = i + 1;
            }

            Combinations(0, 0);
        }

        private static void Combinations(int index, int loopIdx)
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
