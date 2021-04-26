using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations_without_Repetition
{
    class Program
    {
        private static bool[] used;
        private static string[] characters;
        private static string[] permutations;

        static void Main(string[] args)
        {
           characters = Console.ReadLine().Split().ToArray();

            permutations = new string[characters.Length];

            used = new bool[characters.Length];

            for (int i = 0; i < used.Length; i++)
            {
                used[i] = false;
            }

            Permutations(0);

        }

        private static void Permutations(int index)
        {
            if (index == characters.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            for (int i = 0; i < characters.Length; i++)
            {
                if(used[i] == false)
                {
                    used[i] = true;
                    permutations[index] = characters[i];
                    Permutations(index + 1);
                    used[i] = false;
                }
                
            }
        }
    }
}
