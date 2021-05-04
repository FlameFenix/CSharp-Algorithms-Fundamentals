using System;
using System.Linq;

namespace Selection_Sort
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
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int firstElement = arr[i];
                    int secondElement = arr[j];

                    if(firstElement > secondElement)
                    {
                        Swap(arr, i, j);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        static void Swap(int[] arr , int first, int second)
        {
            int backup = arr[first];
            arr[first] = arr[second];
            arr[second] = backup;
        }
    }
}
