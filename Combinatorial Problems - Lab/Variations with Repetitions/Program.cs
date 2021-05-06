using System;
using System.Linq;

namespace Variations_with_Repetitions
{
    class Program
    {
        private static char[] elements;
        private static char[] variations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              .Select(char.Parse)
                              .ToArray();

            int k = int.Parse(Console.ReadLine());

            variations = new char[k];

            for (int i = 0; i < variations.Length; i++)
            {
                variations[i] = elements[i];
            }

            Variations(0);
        }

        private static void Variations(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                variations[index] = elements[i];
                Variations(index + 1);
            }
        }
    }
}
