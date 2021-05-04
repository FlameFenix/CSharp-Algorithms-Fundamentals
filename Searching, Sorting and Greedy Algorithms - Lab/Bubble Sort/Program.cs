using System;
using System.Linq;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    int firstElement = arr[j - 1];
                    int secondElement = arr[j];

                    if(firstElement > secondElement)
                    {
                        Swap(arr, j - 1, j);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        private static void Swap(int[] arr, int first, int second)
        {
            int backup = arr[first];
            arr[first] = arr[second];
            arr[second] = backup;
        }
    }
}
