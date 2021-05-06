using System;
using System.Linq;

namespace Variations_without_Repetitions
{
    class Program
    {
        private static char[] elements;
        private static char[] variations;
        private static bool[] usedCharacters;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            variations = new char[k];
            elements = input.Replace(" ", "").ToCharArray().OrderBy(x => x).ToArray();
            usedCharacters = new bool[elements.Length];

            for (int i = 0; i < variations.Length; i++)
            {
                variations[i] = elements[i];
            }

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if(!usedCharacters[i])
                {
                    variations[index] = elements[i];
                    usedCharacters[i] = true;
                    Permute(index + 1);
                    usedCharacters[i] = false;
                } 
            }
        }

        private static void Swap(int first, int second)
        {
            char backup = variations[first];
            variations[first] = variations[second];
            variations[second] = backup;
        }
    }
}
