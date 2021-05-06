using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations_with_Repetition
{
    class Program
    {
        static char[] elements;
        static HashSet<string> setElements;

        static void Main(string[] args)
        {
            elements = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              .Select(char.Parse)
                              .ToArray();

            setElements = new HashSet<string>();

            Permute(0);

            foreach (var item in setElements)
            {
                Console.WriteLine(item);
            }
        }

        static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                setElements.Add(string.Join(" ", elements));
                return;
            }

            Permute(index + 1);

            HashSet<char> set = new HashSet<char>() { elements[index] };

            for (int i = index + 1; i < elements.Length; i++)
            {
                int first = index;
                int second = i;
                if(!set.Contains(elements[i]))
                {
                    Swap(first, second);
                    Permute(index + 1);
                    Swap(first, second);
                    set.Add(elements[i]);
                }
            }

        }

        static void Swap(int first, int second)
        {
            char backup = elements[first];
            elements[first] = elements[second];
            elements[second] = backup;
        }
    }
}
